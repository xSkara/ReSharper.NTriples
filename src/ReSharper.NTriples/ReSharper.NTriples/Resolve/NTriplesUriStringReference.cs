﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   NTriplesUriStringReference.cs
// </summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;
using ReSharper.NTriples.Cache;
using ReSharper.NTriples.Impl.Tree;
using ReSharper.NTriples.Tree;
using ReSharper.NTriples.Util;
using UriString = ReSharper.NTriples.Impl.Tree.UriString;

namespace ReSharper.NTriples.Resolve
{
    public class NTriplesUriStringReference : NTriplesReferenceBase
    {
        public NTriplesUriStringReference(ITreeNode node)
            : base(node)
        {
        }

        public override IReference BindTo(IDeclaredElement element)
        {
            var uriString = (IUriString)this.GetTreeNode();
            if (uriString.Parent != null)
            {
                PsiTreeUtil.ReplaceChild(uriString, uriString.FirstChild, element.ShortName);
                uriString.SetReferenceName(element.ShortName);
            }

            return this;
        }

        public override IReference BindTo(IDeclaredElement element, ISubstitution substitution)
        {
            return this.BindTo(element);
        }

        public override ISymbolTable GetReferenceSymbolTable(bool useReferenceName)
        {
            var file = this.TreeNode.GetContainingFile() as NTriplesFile;
            if (file == null)
            {
                return EmptySymbolTable.INSTANCE;
            }

            var uriString = (UriString)this.myOwner;
            var @namespace = uriString.GetNamespace();
            if (string.IsNullOrEmpty(@namespace))
            {
                var cache = this.myOwner.GetSolution().GetComponent<NTriplesCache>();
                var psiServices = this.myOwner.GetPsiServices();

                var elements = cache.GetAllUriIdentifiersInNamespace(@namespace)
                                    .Select(
                                        x => new UriIdentifierDeclaredElement(file, x.Namespace, x.LocalName, x.Info, psiServices));

                var symbolTable = ResolveUtil.CreateSymbolTable(elements, 0);
                return symbolTable;
            }

            return EmptySymbolTable.INSTANCE;
        }

        public override ResolveResultWithInfo ResolveWithoutCache()
        {
            return new ResolveResultWithInfo(
                ResolveResultFactory.CreateResolveResultFinaly(new List<DeclaredElementInstance>()), ResolveErrorType.OK);
            /*ISymbolTable table = this.GetReferenceSymbolTable(true);
            IList<DeclaredElementInstance> elements = new List<DeclaredElementInstance>();
            {
                IList<ISymbolInfo> infos = table.GetSymbolInfos(this.GetName());
                foreach (ISymbolInfo info in infos)
                {
                    var element = new DeclaredElementInstance(info.GetDeclaredElement(), EmptySubstitution.INSTANCE);
                    elements.Add(element);
                }
            }

            return new ResolveResultWithInfo(ResolveResultFactory.CreateResolveResultFinaly(elements), ResolveErrorType.OK);*/
        }

        public void SetName(string shortName)
        {
            this.Name = shortName;
        }
    }
}
