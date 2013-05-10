﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   SecretMatchingBraceProvider.cs
// </summary>
// ***********************************************************************

using JetBrains.ReSharper.Feature.Services.MatchingBrace;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;
using ReSharper.NTriples.Impl;
using ReSharper.NTriples.Parsing;

namespace ReSharper.NTriples.Feature.Services.MatchingBrace
{
    [Language(typeof(NTriplesLanguage))]
    internal class NTriplesMatchingBraceProvider : ISimpleMatchingBraceProvider
    {
        public int Compare(TokenNodeType x, TokenNodeType y)
        {
            if ((this.IsLeftBracket(x) && this.IsLeftBracket(y)) || (this.IsRightBracket(x) && this.IsRightBracket(y)))
            {
                if (x == SecretTokenType.L_BRACE)
                {
                    return 1;
                }
                if (y == SecretTokenType.L_BRACE)
                {
                    return -1;
                }
                if (x == SecretTokenType.R_BRACE)
                {
                    return 1;
                }
                if (y == SecretTokenType.R_BRACE)
                {
                    return -1;
                }
            }
            return 0;
        }

        public bool IsLeftBracket(TokenNodeType tokenType)
        {
            if (((tokenType != SecretTokenType.L_BRACE) && (tokenType != SecretTokenType.L_PARENTHESES)) &&
                (tokenType != SecretTokenType.L_BRACKET))
            {
                return false;
            }
            return true;
        }

        public bool IsRightBracket(TokenNodeType tokenType)
        {
            if (((tokenType != SecretTokenType.R_BRACE) && (tokenType != SecretTokenType.R_PARENTHESES)) &&
                (tokenType != SecretTokenType.R_BRACKET))
            {
                return false;
            }
            return true;
        }

        public bool Match(TokenNodeType token1, TokenNodeType token2)
        {
            if (token1 == SecretTokenType.L_BRACE)
            {
                return (token2 == SecretTokenType.R_BRACE);
            }
            if (token1 == SecretTokenType.L_PARENTHESES)
            {
                return (token2 == SecretTokenType.R_PARENTHESES);
            }
            if (token1 == SecretTokenType.L_BRACKET)
            {
                return (token2 == SecretTokenType.R_BRACKET);
            }
            if (token1 == SecretTokenType.R_BRACE)
            {
                return (token2 == SecretTokenType.L_BRACE);
            }
            if (token1 == SecretTokenType.R_PARENTHESES)
            {
                return (token2 == SecretTokenType.L_PARENTHESES);
            }
            if (token1 == SecretTokenType.R_BRACKET)
            {
                return (token2 == SecretTokenType.L_BRACKET);
            }

            return false;
        }
    }
}
