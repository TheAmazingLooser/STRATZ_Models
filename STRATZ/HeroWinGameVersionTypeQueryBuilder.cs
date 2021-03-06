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
    public partial class HeroWinGameVersionTypeQueryBuilder : GraphQlQueryBuilder<HeroWinGameVersionTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "gameVersionId", IsComplex = true },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "durationMinute", IsComplex = true },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "matchCount" }
            };

        protected override string TypeName { get { return "HeroWinGameVersionType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroWinGameVersionTypeQueryBuilder WithGameVersionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameVersionId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroWinGameVersionTypeQueryBuilder ExceptGameVersionId()
        {
            return ExceptField("gameVersionId");
        }

        public HeroWinGameVersionTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroWinGameVersionTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroWinGameVersionTypeQueryBuilder WithDurationMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroWinGameVersionTypeQueryBuilder ExceptDurationMinute()
        {
            return ExceptField("durationMinute");
        }

        public HeroWinGameVersionTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroWinGameVersionTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public HeroWinGameVersionTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroWinGameVersionTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }
    }
}
