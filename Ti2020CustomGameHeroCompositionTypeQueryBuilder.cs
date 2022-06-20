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
    public partial class Ti2020CustomGameHeroCompositionTypeQueryBuilder : GraphQlQueryBuilder<Ti2020CustomGameHeroCompositionTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "difficulty" },
                new FieldMetadata { Name = "heroId1", IsComplex = true },
                new FieldMetadata { Name = "heroId2", IsComplex = true },
                new FieldMetadata { Name = "heroId3", IsComplex = true },
                new FieldMetadata { Name = "heroId4", IsComplex = true },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "duration" },
                new FieldMetadata { Name = "wilsonScore", IsComplex = true }
            };

        protected override string TypeName { get { return "TI2020CustomGameHeroCompositionType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithDifficulty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("difficulty", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptDifficulty()
        {
            return ExceptField("difficulty");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithHeroId1(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId1", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptHeroId1()
        {
            return ExceptField("heroId1");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithHeroId2(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId2", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptHeroId2()
        {
            return ExceptField("heroId2");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithHeroId3(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId3", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptHeroId3()
        {
            return ExceptField("heroId3");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithHeroId4(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId4", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptHeroId4()
        {
            return ExceptField("heroId4");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("duration", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptDuration()
        {
            return ExceptField("duration");
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder WithWilsonScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wilsonScore", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameHeroCompositionTypeQueryBuilder ExceptWilsonScore()
        {
            return ExceptField("wilsonScore");
        }
    }
}
