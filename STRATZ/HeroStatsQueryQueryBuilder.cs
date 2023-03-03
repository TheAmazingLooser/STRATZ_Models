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
    public partial class HeroStatsQueryQueryBuilder : GraphQlQueryBuilder<HeroStatsQueryQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "stats", IsComplex = true, QueryBuilderType = typeof(HeroPositionTimeDetailTypeQueryBuilder) },
                new FieldMetadata { Name = "matchUp", IsComplex = true, QueryBuilderType = typeof(HeroDryadTypeQueryBuilder) },
                new FieldMetadata { Name = "itemFullPurchase", IsComplex = true, QueryBuilderType = typeof(HeroItemPurchaseTypeQueryBuilder) },
                new FieldMetadata { Name = "itemStartingPurchase", IsComplex = true, QueryBuilderType = typeof(HeroItemStartingPurchaseTypeQueryBuilder) },
                new FieldMetadata { Name = "itemBootPurchase", IsComplex = true, QueryBuilderType = typeof(HeroItemBootPurchaseTypeQueryBuilder) },
                new FieldMetadata { Name = "itemNeutral", IsComplex = true, QueryBuilderType = typeof(HeroNeutralItemTypeQueryBuilder) },
                new FieldMetadata { Name = "laneOutcome", IsComplex = true, QueryBuilderType = typeof(HeroLaneOutcomeTypeQueryBuilder) },
                new FieldMetadata { Name = "heroVsHeroMatchup", IsComplex = true, QueryBuilderType = typeof(HeroMatchupTypeQueryBuilder) },
                new FieldMetadata { Name = "talent", IsComplex = true, QueryBuilderType = typeof(HeroAbilityTalentTypeQueryBuilder) },
                new FieldMetadata { Name = "winHour", IsComplex = true, QueryBuilderType = typeof(HeroWinHourTypeQueryBuilder) },
                new FieldMetadata { Name = "winDay", IsComplex = true, QueryBuilderType = typeof(HeroWinDayTypeQueryBuilder) },
                new FieldMetadata { Name = "winWeek", IsComplex = true, QueryBuilderType = typeof(HeroWinWeekTypeQueryBuilder) },
                new FieldMetadata { Name = "winMonth", IsComplex = true, QueryBuilderType = typeof(HeroWinMonthTypeQueryBuilder) },
                new FieldMetadata { Name = "winGameVersion", IsComplex = true, QueryBuilderType = typeof(HeroWinGameVersionTypeQueryBuilder) },
                new FieldMetadata { Name = "guide", IsComplex = true, QueryBuilderType = typeof(HeroGuideListTypeQueryBuilder) },
                new FieldMetadata { Name = "rampages", IsComplex = true, QueryBuilderType = typeof(HeroRampageObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "abilityMinLevel", IsComplex = true, QueryBuilderType = typeof(HeroAbilityMinTypeQueryBuilder) },
                new FieldMetadata { Name = "abilityMaxLevel", IsComplex = true, QueryBuilderType = typeof(HeroAbilityMaxTypeQueryBuilder) },
                new FieldMetadata { Name = "banDay", IsComplex = true, QueryBuilderType = typeof(HeroBanTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "HeroStatsQuery"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroStatsQueryQueryBuilder WithStats(HeroPositionTimeDetailTypeQueryBuilder heroPositionTimeDetailTypeQueryBuilder, QueryBuilderParameter<IEnumerable<object>> heroIds = null, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<bool?> groupByTime = null, QueryBuilderParameter<bool?> groupByPosition = null, QueryBuilderParameter<bool?> groupByBracket = null, QueryBuilderParameter<int?> minTime = null, QueryBuilderParameter<int?> maxTime = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );

            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (groupByTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupByTime", ArgumentValue = groupByTime} );

            if (groupByPosition != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupByPosition", ArgumentValue = groupByPosition} );

            if (groupByBracket != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupByBracket", ArgumentValue = groupByBracket} );

            if (minTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "minTime", ArgumentValue = minTime} );

            if (maxTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "maxTime", ArgumentValue = maxTime} );

            return WithObjectField("stats", alias, heroPositionTimeDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptStats()
        {
            return ExceptField("stats");
        }

        public HeroStatsQueryQueryBuilder WithMatchUp(HeroDryadTypeQueryBuilder heroDryadTypeQueryBuilder, QueryBuilderParameter<object> heroId = null, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<object> orderBy = null, QueryBuilderParameter<int?> matchLimit = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );

            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "orderBy", ArgumentValue = orderBy} );

            if (matchLimit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "matchLimit", ArgumentValue = matchLimit} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("matchUp", alias, heroDryadTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptMatchUp()
        {
            return ExceptField("matchUp");
        }

        public HeroStatsQueryQueryBuilder WithItemFullPurchase(HeroItemPurchaseTypeQueryBuilder heroItemPurchaseTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<int?> minTime = null, QueryBuilderParameter<int?> maxTime = null, QueryBuilderParameter<int?> matchLimit = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (minTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "minTime", ArgumentValue = minTime} );

            if (maxTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "maxTime", ArgumentValue = maxTime} );

            if (matchLimit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "matchLimit", ArgumentValue = matchLimit} );

            return WithObjectField("itemFullPurchase", alias, heroItemPurchaseTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptItemFullPurchase()
        {
            return ExceptField("itemFullPurchase");
        }

        public HeroStatsQueryQueryBuilder WithItemStartingPurchase(HeroItemStartingPurchaseTypeQueryBuilder heroItemStartingPurchaseTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("itemStartingPurchase", alias, heroItemStartingPurchaseTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptItemStartingPurchase()
        {
            return ExceptField("itemStartingPurchase");
        }

        public HeroStatsQueryQueryBuilder WithItemBootPurchase(HeroItemBootPurchaseTypeQueryBuilder heroItemBootPurchaseTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("itemBootPurchase", alias, heroItemBootPurchaseTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptItemBootPurchase()
        {
            return ExceptField("itemBootPurchase");
        }

        public HeroStatsQueryQueryBuilder WithItemNeutral(HeroNeutralItemTypeQueryBuilder heroNeutralItemTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("itemNeutral", alias, heroNeutralItemTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptItemNeutral()
        {
            return ExceptField("itemNeutral");
        }

        public HeroStatsQueryQueryBuilder WithLaneOutcome(HeroLaneOutcomeTypeQueryBuilder heroLaneOutcomeTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<bool> isWith, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "isWith", ArgumentValue = isWith} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("laneOutcome", alias, heroLaneOutcomeTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptLaneOutcome()
        {
            return ExceptField("laneOutcome");
        }

        public HeroStatsQueryQueryBuilder WithHeroVsHeroMatchup(HeroMatchupTypeQueryBuilder heroMatchupTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<int?> matchLimit = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (matchLimit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "matchLimit", ArgumentValue = matchLimit} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("heroVsHeroMatchup", alias, heroMatchupTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptHeroVsHeroMatchup()
        {
            return ExceptField("heroVsHeroMatchup");
        }

        public HeroStatsQueryQueryBuilder WithTalent(HeroAbilityTalentTypeQueryBuilder heroAbilityTalentTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("talent", alias, heroAbilityTalentTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptTalent()
        {
            return ExceptField("talent");
        }

        public HeroStatsQueryQueryBuilder WithWinHour(HeroWinHourTypeQueryBuilder heroWinHourTypeQueryBuilder, QueryBuilderParameter<IEnumerable<object>> heroIds = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<IEnumerable<RankBracket?>> bracketIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<IEnumerable<BasicRegionType?>> regionIds = null, QueryBuilderParameter<IEnumerable<GameModeEnumType?>> gameModeIds = null, QueryBuilderParameter<FilterHeroWinRequestGroupBy?> groupBy = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (bracketIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketIds", ArgumentValue = bracketIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (regionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "regionIds", ArgumentValue = regionIds} );

            if (gameModeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameModeIds", ArgumentValue = gameModeIds} );

            if (groupBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupBy", ArgumentValue = groupBy} );

            return WithObjectField("winHour", alias, heroWinHourTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptWinHour()
        {
            return ExceptField("winHour");
        }

        public HeroStatsQueryQueryBuilder WithWinDay(HeroWinDayTypeQueryBuilder heroWinDayTypeQueryBuilder, QueryBuilderParameter<IEnumerable<object>> heroIds = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<IEnumerable<RankBracket?>> bracketIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<IEnumerable<BasicRegionType?>> regionIds = null, QueryBuilderParameter<IEnumerable<GameModeEnumType?>> gameModeIds = null, QueryBuilderParameter<FilterHeroWinRequestGroupBy?> groupBy = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (bracketIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketIds", ArgumentValue = bracketIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (regionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "regionIds", ArgumentValue = regionIds} );

            if (gameModeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameModeIds", ArgumentValue = gameModeIds} );

            if (groupBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupBy", ArgumentValue = groupBy} );

            return WithObjectField("winDay", alias, heroWinDayTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptWinDay()
        {
            return ExceptField("winDay");
        }

        public HeroStatsQueryQueryBuilder WithWinWeek(HeroWinWeekTypeQueryBuilder heroWinWeekTypeQueryBuilder, QueryBuilderParameter<IEnumerable<object>> heroIds = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<IEnumerable<RankBracket?>> bracketIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<IEnumerable<BasicRegionType?>> regionIds = null, QueryBuilderParameter<IEnumerable<GameModeEnumType?>> gameModeIds = null, QueryBuilderParameter<FilterHeroWinRequestGroupBy?> groupBy = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (bracketIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketIds", ArgumentValue = bracketIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (regionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "regionIds", ArgumentValue = regionIds} );

            if (gameModeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameModeIds", ArgumentValue = gameModeIds} );

            if (groupBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupBy", ArgumentValue = groupBy} );

            return WithObjectField("winWeek", alias, heroWinWeekTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptWinWeek()
        {
            return ExceptField("winWeek");
        }

        public HeroStatsQueryQueryBuilder WithWinMonth(HeroWinMonthTypeQueryBuilder heroWinMonthTypeQueryBuilder, QueryBuilderParameter<IEnumerable<object>> heroIds = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<IEnumerable<RankBracket?>> bracketIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<IEnumerable<BasicRegionType?>> regionIds = null, QueryBuilderParameter<IEnumerable<GameModeEnumType?>> gameModeIds = null, QueryBuilderParameter<FilterHeroWinRequestGroupBy?> groupBy = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (bracketIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketIds", ArgumentValue = bracketIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (regionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "regionIds", ArgumentValue = regionIds} );

            if (gameModeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameModeIds", ArgumentValue = gameModeIds} );

            if (groupBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupBy", ArgumentValue = groupBy} );

            return WithObjectField("winMonth", alias, heroWinMonthTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptWinMonth()
        {
            return ExceptField("winMonth");
        }

        public HeroStatsQueryQueryBuilder WithWinGameVersion(HeroWinGameVersionTypeQueryBuilder heroWinGameVersionTypeQueryBuilder, QueryBuilderParameter<IEnumerable<object>> heroIds = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<IEnumerable<RankBracket?>> bracketIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, QueryBuilderParameter<IEnumerable<BasicRegionType?>> regionIds = null, QueryBuilderParameter<IEnumerable<GameModeEnumType?>> gameModeIds = null, QueryBuilderParameter<FilterHeroWinRequestGroupBy?> groupBy = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (bracketIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketIds", ArgumentValue = bracketIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            if (regionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "regionIds", ArgumentValue = regionIds} );

            if (gameModeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameModeIds", ArgumentValue = gameModeIds} );

            if (groupBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupBy", ArgumentValue = groupBy} );

            return WithObjectField("winGameVersion", alias, heroWinGameVersionTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptWinGameVersion()
        {
            return ExceptField("winGameVersion");
        }

        public HeroStatsQueryQueryBuilder WithGuide(HeroGuideListTypeQueryBuilder heroGuideListTypeQueryBuilder, QueryBuilderParameter<object> heroId = null, QueryBuilderParameter<object> withHeroId = null, QueryBuilderParameter<object> againstHeroId = null, QueryBuilderParameter<bool?> isPro = null, QueryBuilderParameter<MatchPlayerPositionType?> positionId = null, QueryBuilderParameter<object> itemId = null, QueryBuilderParameter<object> neutralItemId = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );

            if (withHeroId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withHeroId", ArgumentValue = withHeroId} );

            if (againstHeroId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "againstHeroId", ArgumentValue = againstHeroId} );

            if (isPro != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "isPro", ArgumentValue = isPro} );

            if (positionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionId", ArgumentValue = positionId} );

            if (itemId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "itemId", ArgumentValue = itemId} );

            if (neutralItemId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "neutralItemId", ArgumentValue = neutralItemId} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            return WithObjectField("guide", alias, heroGuideListTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptGuide()
        {
            return ExceptField("guide");
        }

        public HeroStatsQueryQueryBuilder WithRampages(HeroRampageObjectTypeQueryBuilder heroRampageObjectTypeQueryBuilder, QueryBuilderParameter<FilterHeroRampageType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("rampages", alias, heroRampageObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptRampages()
        {
            return ExceptField("rampages");
        }

        public HeroStatsQueryQueryBuilder WithAbilityMinLevel(HeroAbilityMinTypeQueryBuilder heroAbilityMinTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("abilityMinLevel", alias, heroAbilityMinTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptAbilityMinLevel()
        {
            return ExceptField("abilityMinLevel");
        }

        public HeroStatsQueryQueryBuilder WithAbilityMaxLevel(HeroAbilityMaxTypeQueryBuilder heroAbilityMaxTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<object> week = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<IEnumerable<MatchPlayerPositionType?>> positionIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (week != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "week", ArgumentValue = week} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (positionIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "positionIds", ArgumentValue = positionIds} );

            return WithObjectField("abilityMaxLevel", alias, heroAbilityMaxTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptAbilityMaxLevel()
        {
            return ExceptField("abilityMaxLevel");
        }

        public HeroStatsQueryQueryBuilder WithBanDay(HeroBanTypeQueryBuilder heroBanTypeQueryBuilder, QueryBuilderParameter<object> heroId, QueryBuilderParameter<int?> day = null, QueryBuilderParameter<IEnumerable<RankBracketBasicEnum?>> bracketBasicIds = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<bool?> groupByDay = null, QueryBuilderParameter<bool?> groupByRank = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            if (day != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "day", ArgumentValue = day} );

            if (bracketBasicIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracketBasicIds", ArgumentValue = bracketBasicIds} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (groupByDay != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupByDay", ArgumentValue = groupByDay} );

            if (groupByRank != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupByRank", ArgumentValue = groupByRank} );

            return WithObjectField("banDay", alias, heroBanTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public HeroStatsQueryQueryBuilder ExceptBanDay()
        {
            return ExceptField("banDay");
        }
    }
}
