﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   PrefixIdentifier.cs
// </summary>
// ***********************************************************************

using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Impl.Resolve;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using ReSharper.NTriples.Impl;
using ReSharper.NTriples.Parsing;

namespace ReSharper.NTriples.Tree
{
    internal class PrefixIdentifier : NTriplesTokenBase, INTriplesIdentifier
    {
        private readonly string myText;

        public PrefixIdentifier(string text)
        {
            this.myText = text;
        }

        public override PsiLanguageType Language
        {
            get
            {
                return NTriplesLanguage.Instance;
            }
        }

        public string Name
        {
            get
            {
                return CSharpResolveUtil.ReferenceName(this.myText);
            }
        }

        public override NodeType NodeType
        {
            get
            {
                return NTriplesTokenType.PREFIX_IDENTIFIER;
            }
        }

        public override string GetText()
        {
            return this.myText;
        }

        public override int GetTextLength()
        {
            return this.myText.Length;
        }
    }
}
