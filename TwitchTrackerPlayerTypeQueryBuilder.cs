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
    public partial class TwitchTrackerPlayerTypeQueryBuilder : GraphQlQueryBuilder<TwitchTrackerPlayerTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "activity" },
                new FieldMetadata { Name = "name" },
                new FieldMetadata { Name = "avatar" },
                new FieldMetadata { Name = "rank" },
                new FieldMetadata { Name = "leaderboardRank" },
                new FieldMetadata { Name = "proPlayerName" },
                new FieldMetadata { Name = "matchCountLast100" },
                new FieldMetadata { Name = "winCountLast100" },
                new FieldMetadata { Name = "uniqueHeroLast100" },
                new FieldMetadata { Name = "coreCountLast100" },
                new FieldMetadata { Name = "topHeroLast100", IsComplex = true, QueryBuilderType = typeof(TwitchTrackerPlayerHeroTypeQueryBuilder) },
                new FieldMetadata { Name = "matches", IsComplex = true, QueryBuilderType = typeof(TwitchTrackerPlayerMatchTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "TwitchTrackerPlayerType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public TwitchTrackerPlayerTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithActivity(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activity", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptActivity()
        {
            return ExceptField("activity");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithAvatar(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avatar", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptAvatar()
        {
            return ExceptField("avatar");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rank", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptRank()
        {
            return ExceptField("rank");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithLeaderboardRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leaderboardRank", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptLeaderboardRank()
        {
            return ExceptField("leaderboardRank");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithProPlayerName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("proPlayerName", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptProPlayerName()
        {
            return ExceptField("proPlayerName");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithMatchCountLast100(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCountLast100", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptMatchCountLast100()
        {
            return ExceptField("matchCountLast100");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithWinCountLast100(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCountLast100", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptWinCountLast100()
        {
            return ExceptField("winCountLast100");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithUniqueHeroLast100(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("uniqueHeroLast100", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptUniqueHeroLast100()
        {
            return ExceptField("uniqueHeroLast100");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithCoreCountLast100(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("coreCountLast100", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptCoreCountLast100()
        {
            return ExceptField("coreCountLast100");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithTopHeroLast100(TwitchTrackerPlayerHeroTypeQueryBuilder twitchTrackerPlayerHeroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("topHeroLast100", alias, twitchTrackerPlayerHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptTopHeroLast100()
        {
            return ExceptField("topHeroLast100");
        }

        public TwitchTrackerPlayerTypeQueryBuilder WithMatches(TwitchTrackerPlayerMatchTypeQueryBuilder twitchTrackerPlayerMatchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("matches", alias, twitchTrackerPlayerMatchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerTypeQueryBuilder ExceptMatches()
        {
            return ExceptField("matches");
        }
    }
}
