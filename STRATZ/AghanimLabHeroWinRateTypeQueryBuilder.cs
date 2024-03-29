// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class AghanimLabHeroWinRateTypeQueryBuilder : GraphQlQueryBuilder<AghanimLabHeroWinRateTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "difficulty" },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" }
            };

        protected override string TypeName { get { return "AghanimLabHeroWinRateType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AghanimLabHeroWinRateTypeQueryBuilder WithDifficulty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("difficulty", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroWinRateTypeQueryBuilder ExceptDifficulty()
        {
            return ExceptField("difficulty");
        }

        public AghanimLabHeroWinRateTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroWinRateTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public AghanimLabHeroWinRateTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroWinRateTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public AghanimLabHeroWinRateTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroWinRateTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }
    }
}
