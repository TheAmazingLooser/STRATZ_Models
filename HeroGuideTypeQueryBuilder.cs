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
    public partial class HeroGuideTypeQueryBuilder : GraphQlQueryBuilder<HeroGuideTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "matchId", IsComplex = true },
                new FieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new FieldMetadata { Name = "matchPlayer", IsComplex = true, QueryBuilderType = typeof(MatchPlayerTypeQueryBuilder) },
                new FieldMetadata { Name = "createdDateTime", IsComplex = true }
            };

        protected override string TypeName { get { return "HeroGuideType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroGuideTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroGuideTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroGuideTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroGuideTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public HeroGuideTypeQueryBuilder WithMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroGuideTypeQueryBuilder ExceptMatchId()
        {
            return ExceptField("matchId");
        }

        public HeroGuideTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroGuideTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public HeroGuideTypeQueryBuilder WithMatchPlayer(MatchPlayerTypeQueryBuilder matchPlayerTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("matchPlayer", alias, matchPlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroGuideTypeQueryBuilder ExceptMatchPlayer()
        {
            return ExceptField("matchPlayer");
        }

        public HeroGuideTypeQueryBuilder WithCreatedDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("createdDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroGuideTypeQueryBuilder ExceptCreatedDateTime()
        {
            return ExceptField("createdDateTime");
        }
    }
}
