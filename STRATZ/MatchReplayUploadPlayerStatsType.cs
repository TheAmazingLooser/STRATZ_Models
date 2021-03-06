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
    public partial class MatchReplayUploadPlayerStatsType
    {
        public IList<int> KillsList { get; set; }
        public IList<int> AssistsList { get; set; }
        public IList<int> DeathsList { get; set; }
        public IList<int> StreakList { get; set; }
        public IList<int> LevelList { get; set; }
        public IList<int> TotalEarnedGoldList { get; set; }
        public IList<int> ReliableGoldList { get; set; }
        public IList<int> UnreliableGoldList { get; set; }
        public IList<int> TotalEarnedXpList { get; set; }
        public IList<int> SharedGoldList { get; set; }
        public IList<int> HeroKillGoldList { get; set; }
        public IList<int> CreepKillGoldList { get; set; }
        public IList<int> IncomeGoldList { get; set; }
        public IList<int> NetworthList { get; set; }
        public IList<int> DenyCountList { get; set; }
        public IList<int> LastHitCountList { get; set; }
        public IList<int> LastHitStreakList { get; set; }
        public IList<int> LastHitMultiKillList { get; set; }
        public IList<int> NearbyCreepDeathCountList { get; set; }
        public IList<int> ClaimedDenyCountList { get; set; }
        public IList<int> ClaimedMissCountList { get; set; }
        public IList<int> MissCountList { get; set; }
        public IList<int> StunsList { get; set; }
        public IList<int> HeroHealingList { get; set; }
        public IList<int> TowerKillsList { get; set; }
        public IList<int> RoshanKillsList { get; set; }
        public IList<int> ObserverWardsPlacedList { get; set; }
        public IList<int> SentryWardsPlacedList { get; set; }
        public IList<int> CreepStackList { get; set; }
        public IList<int> CampStackList { get; set; }
        public IList<int> RunePicksupList { get; set; }
        public IList<int> GoldSpentOnSupportList { get; set; }
        public IList<int> HeroDamageList { get; set; }
        public IList<int> WardsPurchasedList { get; set; }
        public IList<int> WardsDestroyedList { get; set; }
        public IList<int> CommandsIssuedList { get; set; }
        public IList<int> GoldSpentOnConsumablesList { get; set; }
        public IList<int> GoldSpentOnItemsList { get; set; }
        public IList<int> GoldSpentOnBuybacksList { get; set; }
        public IList<int> GoldLostToDeathList { get; set; }
        public IList<int> MaxHealthList { get; set; }
        public IList<int> MaxManaList { get; set; }
        public IList<int> BkbChargesUsedList { get; set; }
        public IList<int> DamageMinList { get; set; }
        public IList<int> DamageMaxList { get; set; }
        public IList<int> DamageBonusList { get; set; }
        public IList<int> StrengthTotalList { get; set; }
        public IList<int> AgilityTotalList { get; set; }
        public IList<int> IntellectTotalList { get; set; }
        public IList<int> TowerDamageList { get; set; }
        public MatchReplayUploadPlayerStatsItemsType Items { get; set; }
    }
}
