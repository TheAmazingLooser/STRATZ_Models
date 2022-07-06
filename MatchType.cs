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
    public partial class MatchType
    {
        public long? Id { get; set; }
        public bool? DidRadiantWin { get; set; }
        public int? DurationSeconds { get; set; }
        public long? StartDateTime { get; set; }
        public long? EndDateTime { get; set; }
        public int? TowerStatusRadiant { get; set; }
        public int? TowerStatusDire { get; set; }
        public short? BarracksStatusRadiant { get; set; }
        public short? BarracksStatusDire { get; set; }
        public int? ClusterId { get; set; }
        public int? FirstBloodTime { get; set; }
        public LobbyTypeEnum? LobbyType { get; set; }
        public int? NumHumanPlayers { get; set; }
        public GameModeEnumType? GameMode { get; set; }
        public long? ReplaySalt { get; set; }
        public bool? IsStats { get; set; }
        public int? TournamentId { get; set; }
        public short? TournamentRound { get; set; }
        public short? ActualRank { get; set; }
        public short? AverageRank { get; set; }
        public short? AverageImp { get; set; }
        public long? ParsedDateTime { get; set; }
        public long? StatsDateTime { get; set; }
        public int? LeagueId { get; set; }
        public int? RadiantTeamId { get; set; }
        public int? DireTeamId { get; set; }
        public long? SeriesId { get; set; }
        public short? GameVersionId { get; set; }
        public byte? RegionId { get; set; }
        public long? SequenceNum { get; set; }
        public int? Rank { get; set; }
        public byte? Bracket { get; set; }
        public MatchAnalysisOutcomeType? AnalysisOutcome { get; set; }
        public byte? PredictedOutcomeWeight { get; set; }
        public IList<MatchPlayerType> Players { get; set; }
        public TeamType RadiantTeam { get; set; }
        public TeamType DireTeam { get; set; }
        public SeriesType Series { get; set; }
        public MatchStatsType Stats { get; set; }
        public MatchPlaybackDataType PlaybackData { get; set; }
        public IList<MatchPlayerSpectatorType> Spectators { get; set; }
        public LeagueType League { get; set; }
        public LaneOutcomeEnums? BottomLaneOutcome { get; set; }
        public LaneOutcomeEnums? MidLaneOutcome { get; set; }
        public LaneOutcomeEnums? TopLaneOutcome { get; set; }
    }
}
