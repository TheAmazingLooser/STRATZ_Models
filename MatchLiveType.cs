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
    public partial class MatchLiveType
    {
        public long? MatchId { get; set; }
        public byte? RadiantScore { get; set; }
        public byte? DireScore { get; set; }
        public int? LeagueId { get; set; }
        public LeagueType League { get; set; }
        public short? Delay { get; set; }
        public int? Spectators { get; set; }
        public int? AverageRank { get; set; }
        public long? BuildingState { get; set; }
        public int? RadiantLead { get; set; }
        public long? LobbyId { get; set; }
        public LobbyTypeEnum? LobbyType { get; set; }
        public string ServerSteamId { get; set; }
        public int? GameTime { get; set; }
        public bool? Completed { get; set; }
        public bool? IsUpdating { get; set; }
        public bool? IsParsing { get; set; }
        public int? RadiantTeamId { get; set; }
        public int? DireTeamId { get; set; }
        public TeamType RadiantTeam { get; set; }
        public TeamType DireTeam { get; set; }
        public int? ParseBeginGameTime { get; set; }
        public byte? NumHumanPlayers { get; set; }
        public GameModeEnumType? GameMode { get; set; }
        public MatchLivePlaybackDataType PlaybackData { get; set; }
        public MatchLiveGameState? GameState { get; set; }
        public short? GameMinute { get; set; }
        public IList<MatchLivePlayerType> Players { get; set; }
        public long? CreatedDateTime { get; set; }
        public long? ModifiedDateTime { get; set; }
        public MatchLiveInsightType Insight { get; set; }
        public IList<decimal> WinRateValues { get; set; }
        public IList<decimal> DurationValues { get; set; }
        public IList<MatchLiveWinRateDetailType> LiveWinRateValues { get; set; }
    }
}
