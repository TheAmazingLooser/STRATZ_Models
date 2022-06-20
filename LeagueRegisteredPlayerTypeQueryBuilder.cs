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
    public partial class LeagueRegisteredPlayerTypeQueryBuilder : GraphQlQueryBuilder<LeagueRegisteredPlayerTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "leagueId" },
                new FieldMetadata { Name = "league", IsComplex = true, QueryBuilderType = typeof(LeagueTypeQueryBuilder) },
                new FieldMetadata { Name = "teamId" },
                new FieldMetadata { Name = "radiantTeam", IsComplex = true, QueryBuilderType = typeof(TeamTypeQueryBuilder) },
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LeagueRegisteredPlayerType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueRegisteredPlayerTypeQueryBuilder WithLeagueId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leagueId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueRegisteredPlayerTypeQueryBuilder ExceptLeagueId()
        {
            return ExceptField("leagueId");
        }

        public LeagueRegisteredPlayerTypeQueryBuilder WithLeague(LeagueTypeQueryBuilder leagueTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("league", alias, leagueTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueRegisteredPlayerTypeQueryBuilder ExceptLeague()
        {
            return ExceptField("league");
        }

        public LeagueRegisteredPlayerTypeQueryBuilder WithTeamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueRegisteredPlayerTypeQueryBuilder ExceptTeamId()
        {
            return ExceptField("teamId");
        }

        public LeagueRegisteredPlayerTypeQueryBuilder WithRadiantTeam(TeamTypeQueryBuilder teamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("radiantTeam", alias, teamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueRegisteredPlayerTypeQueryBuilder ExceptRadiantTeam()
        {
            return ExceptField("radiantTeam");
        }

        public LeagueRegisteredPlayerTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueRegisteredPlayerTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public LeagueRegisteredPlayerTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueRegisteredPlayerTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }
    }
}
