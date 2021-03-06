// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   NTriplesFilteringLexer.cs
// </summary>
// ***********************************************************************

using JetBrains.ReSharper.Psi.Parsing;
using ReSharper.NTriples.Impl;

namespace ReSharper.NTriples.Parsing
{
    internal class NTriplesFilteringLexer : FilteringLexer, ILexer<int>
    {
        public NTriplesFilteringLexer(ILexer lexer) : base(lexer)
        {
        }

        public ILexer OriginalLexer
        {
            get
            {
                return this.myLexer;
            }
        }

        int ILexer<int>.CurrentPosition
        {
            get
            {
                return ((ILexer<int>)this.myLexer).CurrentPosition;
            }
            set
            {
                ((ILexer<int>)this.myLexer).CurrentPosition = value;
            }
        }

        protected override bool Skip(TokenNodeType tokenType)
        {
            return NTriplesLanguageService.WHITESPACE_OR_COMMENT[tokenType];
        }
    }
}
