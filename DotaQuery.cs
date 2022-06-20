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
    public partial class DotaQuery
    {
        public MatchType Match { get; set; }
        public IList<MatchType> Matches { get; set; }
        public PlayerType Player { get; set; }
        public IList<PlayerType> Players { get; set; }
        public TeamType Team { get; set; }
        public IList<TeamType> Teams { get; set; }
        public LeagueType League { get; set; }
        public IList<LeagueType> Leagues { get; set; }
        public GuildType Guild { get; set; }
        public YogurtQuery Yogurt { get; set; }
        public PlusQuery Plus { get; set; }
        public StratzQuery Stratz { get; set; }
        public HeroStatsQuery HeroStats { get; set; }
        public ConstantQuery Constants { get; set; }
        public LeaderboardQuery Leaderboard { get; set; }
        public LiveQuery Live { get; set; }
        public VendorQuery Vendor { get; set; }
    }
}
