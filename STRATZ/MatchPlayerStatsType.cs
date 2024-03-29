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
    public partial class MatchPlayerStatsType
    {
        public long? MatchId { get; set; }
        public long? SteamAccountId { get; set; }
        public short? GameVersionId { get; set; }
        public IList<int> Level { get; set; }
        public IList<MatchPlayerStatsKillEventType> KillEvents { get; set; }
        public IList<MatchPlayerStatsDeathEventType> DeathEvents { get; set; }
        public IList<MatchPlayerStatsAssistEventType> AssistEvents { get; set; }
        public IList<int> LastHitsPerMinute { get; set; }
        public IList<int> GoldPerMinute { get; set; }
        public IList<int> ExperiencePerMinute { get; set; }
        public IList<int> HealPerMinute { get; set; }
        public IList<int> HeroDamagePerMinute { get; set; }
        public IList<int> TowerDamagePerMinute { get; set; }
        public IList<MatchPlayerStatsTowerDamageReportType> TowerDamageReport { get; set; }
        public IList<MatchPlayerStatsCourierKillEventType> CourierKills { get; set; }
        public IList<MatchPlayerStatsWardEventType> Wards { get; set; }
        public IList<MatchPlayerItemPurchaseEventType> ItemPurchases { get; set; }
        public IList<MatchPlayerStatsItemUsedEventType> ItemUsed { get; set; }
        public IList<MatchPlayerStatsAllTalkEventType> AllTalks { get; set; }
        public IList<MatchPlayerStatsChatWheelEventType> ChatWheels { get; set; }
        public IList<int> ActionsPerMinute { get; set; }
        public MatchPlayerStatsActionReportType ActionReport { get; set; }
        public IList<MatchPlayerStatsLocationReportType> LocationReport { get; set; }
        public MatchPlayerStatsFarmDistributionReportType FarmDistributionReport { get; set; }
        public IList<MatchPlayerStatsRuneEventType> Runes { get; set; }
        public IList<MatchPlayerStatsAbilityCastReportType> AbilityCastReport { get; set; }
        public MatchPlayerStatsHeroDamageReportType HeroDamageReport { get; set; }
        public IList<MatchPlayerInventoryType> InventoryReport { get; set; }
        public IList<int> NetworthPerMinute { get; set; }
        public IList<int> CampStack { get; set; }
        public IList<MatchPlayerStatsBuffEventType> MatchPlayerBuffEvent { get; set; }
        public IList<int> DeniesPerMinute { get; set; }
        public IList<int> ImpPerMinute { get; set; }
        public IList<int> TripsFountainPerMinute { get; set; }
        public IList<MatchPlayerSpiritBearInventoryType> SpiritBearInventoryReport { get; set; }
        public IList<int> HeroDamageReceivedPerMinute { get; set; }
        public IList<MatchPlayerWardDestuctionObjectType> WardDestruction { get; set; }
    }
}
