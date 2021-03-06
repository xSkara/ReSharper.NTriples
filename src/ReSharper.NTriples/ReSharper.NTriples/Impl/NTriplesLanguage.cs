// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   NTriplesLanguage.cs
// </summary>
// ***********************************************************************

using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;

namespace ReSharper.NTriples.Impl
{
    [LanguageDefinition(LanguageName)]
    public class NTriplesLanguage : KnownLanguage
    {
        public const string LanguageName = "NTriples";

        [UsedImplicitly]
        public static readonly NTriplesLanguage Instance;

        protected NTriplesLanguage([NotNull] string name) : base(name)
        {
        }

        protected NTriplesLanguage([NotNull] string name, [NotNull] string presentableName) : base(name, presentableName)
        {
        }

        private NTriplesLanguage() : base(LanguageName, "N-Triples")
        {
        }
    }
}
