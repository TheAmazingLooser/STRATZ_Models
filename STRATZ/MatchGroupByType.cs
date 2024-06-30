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
    public partial class MatchGroupByType
    {
        public long? HeroId { get; set; }
        public HeroType Hero { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? AvgImp { get; set; }
        public int? AvgGoldPerMinute { get; set; }
        public int? AvgExperiencePerMinute { get; set; }
        public decimal? AvgKda { get; set; }
        public decimal? AvgKills { get; set; }
        public decimal? AvgDeaths { get; set; }
        public decimal? AvgAssists { get; set; }
        public decimal? AvgTowerDamage { get; set; }
        public long? LastMatchDateTime { get; set; }
        public long? FirstMatchDateTime { get; set; }
        public bool? IsRadiant { get; set; }
        public long? KillCount { get; set; }
        public long? DeathCount { get; set; }
        public long? AssistCount { get; set; }
        public bool? IsLeaver { get; set; }
        public long? Level { get; set; }
        public bool? IsParty { get; set; }
        public bool? IsRandom { get; set; }
        public MatchLaneType? Lane { get; set; }
        public MatchPlayerRoleType? Role { get; set; }
        public bool? IsIntentionalFeeding { get; set; }
        public MatchPlayerAward? Award { get; set; }
        public MatchPlayerAward? RoamLane { get; set; }
        public bool? IsVictory { get; set; }
        public long? DurationMinutes { get; set; }
        public long? Cluster { get; set; }
        public long? Region { get; set; }
        public long? LobbyType { get; set; }
        public bool? IsLeague { get; set; }
        public bool? IsSeries { get; set; }
        public long? GameMode { get; set; }
        public bool? IsStats { get; set; }
        public long? GameVersion { get; set; }
        public long? TeamId { get; set; }
        public TeamType Team { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public long? LeagueId { get; set; }
        public LeagueType League { get; set; }
        public long? DateDay { get; set; }
        public long? TotalKills { get; set; }
        public long? GoldPerMinute { get; set; }
        public short? Hour { get; set; }
    }
}
