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
    public partial class LeagueTableTeamType
    {
        public int? TeamId { get; set; }
        public TeamType Team { get; set; }
        public IList<LeagueRegisteredPlayerType> Members { get; set; }
        public LeagueTableTeamOverviewType Overview { get; set; }
        public LeagueTableTeamStatsType Stats { get; set; }
        public IList<LeagueTableTeamHeroesObjectType> Heroes { get; set; }
        public IList<LeagueTableTeamLanesObjectType> Lanes { get; set; }
    }
}
