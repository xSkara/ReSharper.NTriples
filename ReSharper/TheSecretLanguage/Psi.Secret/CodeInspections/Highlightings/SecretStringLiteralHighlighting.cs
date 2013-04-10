﻿// ***********************************************************************
// <author>Stephan B</author>
// <copyright company="Comindware">
//   Copyright (c) Comindware 2010-2013. All rights reserved.
// </copyright>
// <summary>
//   Strings.cs
// </summary>
// ***********************************************************************

using JetBrains.DocumentModel;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Daemon.Impl;
using JetBrains.ReSharper.Psi.Tree;

[assembly: RegisterConfigurableSeverity("String", null, HighlightingGroupIds.LanguageUsage, "String", @"String", Severity.INFO, false, Internal = false)]

namespace JetBrains.ReSharper.Psi.Secret.CodeInspections.Highlightings
{
    [ConfigurableSeverityHighlighting("String", "Secret", OverlapResolve = OverlapResolveKind.NONE, ToolTipFormatString = "String")]
    internal class SecretStringLiteralHighlighting : ICustomAttributeIdHighlighting, IHighlightingWithRange
    {
        private const string AtributeId = "String"; // a text from the 'Environment -> Fonts and colors -> display items' list
        private readonly ITreeNode myElement;

        public SecretStringLiteralHighlighting(ITreeNode element)
        {
            this.myElement = element;
        }

        public string AttributeId
        {
            get
            {
                return AtributeId;
            }
        }

        public string ErrorStripeToolTip
        {
            get
            {
                return null;
            }
        }

        public int NavigationOffsetPatch
        {
            get
            {
                return 0;
            }
        }

        public string ToolTip
        {
            get
            {
                return null;
            }
        }

        public DocumentRange CalculateRange()
        {
            return this.myElement.GetDocumentRange();
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
