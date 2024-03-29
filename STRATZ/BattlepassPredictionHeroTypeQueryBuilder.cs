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
    public partial class BattlepassPredictionHeroTypeQueryBuilder : GraphQlQueryBuilder<BattlepassPredictionHeroTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "hero", IsComplex = true, QueryBuilderType = typeof(HeroTypeQueryBuilder) },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "matchCountBanned" },
                new FieldMetadata { Name = "winRate" },
                new FieldMetadata { Name = "killAvg" },
                new FieldMetadata { Name = "assistAvg" },
                new FieldMetadata { Name = "deathAvg" },
                new FieldMetadata { Name = "lastHitAvg" },
                new FieldMetadata { Name = "experiencePerMinuteAvg" },
                new FieldMetadata { Name = "mostKills" },
                new FieldMetadata { Name = "mostDeaths" },
                new FieldMetadata { Name = "mostAssists" },
                new FieldMetadata { Name = "mostLastHits" }
            };

        protected override string TypeName { get { return "BattlepassPredictionHeroType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public BattlepassPredictionHeroTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithHero(HeroTypeQueryBuilder heroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("hero", alias, heroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptHero()
        {
            return ExceptField("hero");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithMatchCountBanned(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCountBanned", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptMatchCountBanned()
        {
            return ExceptField("matchCountBanned");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithWinRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winRate", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptWinRate()
        {
            return ExceptField("winRate");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithKillAvg(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("killAvg", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptKillAvg()
        {
            return ExceptField("killAvg");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithAssistAvg(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("assistAvg", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptAssistAvg()
        {
            return ExceptField("assistAvg");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithDeathAvg(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deathAvg", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptDeathAvg()
        {
            return ExceptField("deathAvg");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithLastHitAvg(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastHitAvg", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptLastHitAvg()
        {
            return ExceptField("lastHitAvg");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithExperiencePerMinuteAvg(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("experiencePerMinuteAvg", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptExperiencePerMinuteAvg()
        {
            return ExceptField("experiencePerMinuteAvg");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithMostKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mostKills", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptMostKills()
        {
            return ExceptField("mostKills");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithMostDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mostDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptMostDeaths()
        {
            return ExceptField("mostDeaths");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithMostAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mostAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptMostAssists()
        {
            return ExceptField("mostAssists");
        }

        public BattlepassPredictionHeroTypeQueryBuilder WithMostLastHits(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mostLastHits", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionHeroTypeQueryBuilder ExceptMostLastHits()
        {
            return ExceptField("mostLastHits");
        }
    }
}
