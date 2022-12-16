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
    public partial class AghanimLabPlayerSeasonOneTypeQueryBuilder : GraphQlQueryBuilder<AghanimLabPlayerSeasonOneTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "matchId", IsComplex = true },
                new FieldMetadata { Name = "playerSlot", IsComplex = true },
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "isVictory" },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "hero", IsComplex = true, QueryBuilderType = typeof(HeroTypeQueryBuilder) },
                new FieldMetadata { Name = "deaths", IsComplex = true },
                new FieldMetadata { Name = "leaverStatus", IsComplex = true },
                new FieldMetadata { Name = "numLastHits", IsComplex = true },
                new FieldMetadata { Name = "goldPerMinute", IsComplex = true },
                new FieldMetadata { Name = "networth" },
                new FieldMetadata { Name = "experiencePerMinute", IsComplex = true },
                new FieldMetadata { Name = "level", IsComplex = true },
                new FieldMetadata { Name = "goldSpent" },
                new FieldMetadata { Name = "partyId", IsComplex = true },
                new FieldMetadata { Name = "item0Id", IsComplex = true },
                new FieldMetadata { Name = "item1Id", IsComplex = true },
                new FieldMetadata { Name = "item2Id", IsComplex = true },
                new FieldMetadata { Name = "item3Id", IsComplex = true },
                new FieldMetadata { Name = "item4Id", IsComplex = true },
                new FieldMetadata { Name = "item5Id", IsComplex = true },
                new FieldMetadata { Name = "neutral0Id", IsComplex = true },
                new FieldMetadata { Name = "arcaneFragments", IsComplex = true },
                new FieldMetadata { Name = "bonusArcaneFragments", IsComplex = true },
                new FieldMetadata { Name = "goldBags", IsComplex = true },
                new FieldMetadata { Name = "neutralItemId", IsComplex = true },
                new FieldMetadata { Name = "playerDepthList", IsComplex = true, QueryBuilderType = typeof(AghanimLabPlayerDepthListTypeQueryBuilder) },
                new FieldMetadata { Name = "blessings", IsComplex = true, QueryBuilderType = typeof(AghanimLabPlayerBlessingObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "AghanimLabPlayerSeasonOneType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptMatchId()
        {
            return ExceptField("matchId");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithPlayerSlot(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("playerSlot", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptPlayerSlot()
        {
            return ExceptField("playerSlot");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithIsVictory(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isVictory", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptIsVictory()
        {
            return ExceptField("isVictory");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithHero(HeroTypeQueryBuilder heroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("hero", alias, heroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptHero()
        {
            return ExceptField("hero");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deaths", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptDeaths()
        {
            return ExceptField("deaths");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithLeaverStatus(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leaverStatus", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptLeaverStatus()
        {
            return ExceptField("leaverStatus");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithNumLastHits(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("numLastHits", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptNumLastHits()
        {
            return ExceptField("numLastHits");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptGoldPerMinute()
        {
            return ExceptField("goldPerMinute");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithNetworth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("networth", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptNetworth()
        {
            return ExceptField("networth");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("experiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptExperiencePerMinute()
        {
            return ExceptField("experiencePerMinute");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithGoldSpent(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldSpent", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptGoldSpent()
        {
            return ExceptField("goldSpent");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithPartyId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("partyId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptPartyId()
        {
            return ExceptField("partyId");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithItem0Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item0Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptItem0Id()
        {
            return ExceptField("item0Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithItem1Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item1Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptItem1Id()
        {
            return ExceptField("item1Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithItem2Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item2Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptItem2Id()
        {
            return ExceptField("item2Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithItem3Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item3Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptItem3Id()
        {
            return ExceptField("item3Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithItem4Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item4Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptItem4Id()
        {
            return ExceptField("item4Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithItem5Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item5Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptItem5Id()
        {
            return ExceptField("item5Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithNeutral0Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("neutral0Id", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptNeutral0Id()
        {
            return ExceptField("neutral0Id");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithArcaneFragments(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("arcaneFragments", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptArcaneFragments()
        {
            return ExceptField("arcaneFragments");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithBonusArcaneFragments(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bonusArcaneFragments", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptBonusArcaneFragments()
        {
            return ExceptField("bonusArcaneFragments");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithGoldBags(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldBags", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptGoldBags()
        {
            return ExceptField("goldBags");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithNeutralItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("neutralItemId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptNeutralItemId()
        {
            return ExceptField("neutralItemId");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithPlayerDepthList(AghanimLabPlayerDepthListTypeQueryBuilder aghanimLabPlayerDepthListTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("playerDepthList", alias, aghanimLabPlayerDepthListTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptPlayerDepthList()
        {
            return ExceptField("playerDepthList");
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder WithBlessings(AghanimLabPlayerBlessingObjectTypeQueryBuilder aghanimLabPlayerBlessingObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("blessings", alias, aghanimLabPlayerBlessingObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerSeasonOneTypeQueryBuilder ExceptBlessings()
        {
            return ExceptField("blessings");
        }
    }
}
