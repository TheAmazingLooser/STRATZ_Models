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
    public partial class Ti2020CustomGameMatchTypeQueryBuilder : GraphQlQueryBuilder<Ti2020CustomGameMatchTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "didWin" },
                new FieldMetadata { Name = "durationSeconds", IsComplex = true },
                new FieldMetadata { Name = "startDateTime", IsComplex = true },
                new FieldMetadata { Name = "endDateTime", IsComplex = true },
                new FieldMetadata { Name = "clusterId", IsComplex = true },
                new FieldMetadata { Name = "lobbyType", IsComplex = true },
                new FieldMetadata { Name = "numKills", IsComplex = true },
                new FieldMetadata { Name = "numDeaths", IsComplex = true },
                new FieldMetadata { Name = "numHumanPlayers", IsComplex = true },
                new FieldMetadata { Name = "gameMode", IsComplex = true },
                new FieldMetadata { Name = "replaySalt", IsComplex = true },
                new FieldMetadata { Name = "difficulty" },
                new FieldMetadata { Name = "depth", IsComplex = true },
                new FieldMetadata { Name = "seed" },
                new FieldMetadata { Name = "battlePoints", IsComplex = true },
                new FieldMetadata { Name = "score" },
                new FieldMetadata { Name = "arcaneFragments", IsComplex = true },
                new FieldMetadata { Name = "goldBags", IsComplex = true },
                new FieldMetadata { Name = "regionId", IsComplex = true },
                new FieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(Ti2020CustomGamePlayerTypeQueryBuilder) },
                new FieldMetadata { Name = "depthList", IsComplex = true, QueryBuilderType = typeof(Ti2020CustomGameMatchDepthListTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "TI2020CustomGameMatchType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public Ti2020CustomGameMatchTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithDidWin(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("didWin", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptDidWin()
        {
            return ExceptField("didWin");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithDurationSeconds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationSeconds", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptDurationSeconds()
        {
            return ExceptField("durationSeconds");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithStartDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptStartDateTime()
        {
            return ExceptField("startDateTime");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithEndDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("endDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptEndDateTime()
        {
            return ExceptField("endDateTime");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithClusterId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("clusterId", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptClusterId()
        {
            return ExceptField("clusterId");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithLobbyType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lobbyType", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptLobbyType()
        {
            return ExceptField("lobbyType");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithNumKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("numKills", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptNumKills()
        {
            return ExceptField("numKills");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithNumDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("numDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptNumDeaths()
        {
            return ExceptField("numDeaths");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithNumHumanPlayers(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("numHumanPlayers", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptNumHumanPlayers()
        {
            return ExceptField("numHumanPlayers");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithGameMode(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameMode", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptGameMode()
        {
            return ExceptField("gameMode");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithReplaySalt(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("replaySalt", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptReplaySalt()
        {
            return ExceptField("replaySalt");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithDifficulty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("difficulty", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptDifficulty()
        {
            return ExceptField("difficulty");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithDepth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("depth", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptDepth()
        {
            return ExceptField("depth");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithSeed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seed", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptSeed()
        {
            return ExceptField("seed");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithBattlePoints(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("battlePoints", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptBattlePoints()
        {
            return ExceptField("battlePoints");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("score", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptScore()
        {
            return ExceptField("score");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithArcaneFragments(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("arcaneFragments", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptArcaneFragments()
        {
            return ExceptField("arcaneFragments");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithGoldBags(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldBags", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptGoldBags()
        {
            return ExceptField("goldBags");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithRegionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("regionId", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptRegionId()
        {
            return ExceptField("regionId");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithPlayers(Ti2020CustomGamePlayerTypeQueryBuilder ti2020CustomGamePlayerTypeQueryBuilder, QueryBuilderParameter<object> steamAccountId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (steamAccountId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "steamAccountId", ArgumentValue = steamAccountId} );

            return WithObjectField("players", alias, ti2020CustomGamePlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }

        public Ti2020CustomGameMatchTypeQueryBuilder WithDepthList(Ti2020CustomGameMatchDepthListTypeQueryBuilder ti2020CustomGameMatchDepthListTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("depthList", alias, ti2020CustomGameMatchDepthListTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGameMatchTypeQueryBuilder ExceptDepthList()
        {
            return ExceptField("depthList");
        }
    }
}
