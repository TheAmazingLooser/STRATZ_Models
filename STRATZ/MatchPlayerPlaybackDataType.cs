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
    public partial class MatchPlayerPlaybackDataType
    {
        public IList<AbilityLearnEventsType> AbilityLearnEvents { get; set; }
        public IList<AbilityUsedEventsType> AbilityUsedEvents { get; set; }
        public IList<AbilityActiveListType> AbilityActiveLists { get; set; }
        public IList<ItemUsedEventType> ItemUsedEvents { get; set; }
        public IList<PlayerUpdatePositionDetailType> PlayerUpdatePositionEvents { get; set; }
        public IList<PlayerUpdateGoldDetailType> PlayerUpdateGoldEvents { get; set; }
        public IList<PlayerUpdateAttributeDetailType> PlayerUpdateAttributeEvents { get; set; }
        public IList<PlayerUpdateLevelDetailType> PlayerUpdateLevelEvents { get; set; }
        public IList<PlayerUpdateHealthDetailType> PlayerUpdateHealthEvents { get; set; }
        public IList<PlayerUpdateBattleDetailType> PlayerUpdateBattleEvents { get; set; }
        public IList<KillDetailType> KillEvents { get; set; }
        public IList<DeathDetailType> DeathEvents { get; set; }
        public IList<AssistDetailType> AssistEvents { get; set; }
        public IList<LastHitDetailType> CsEvents { get; set; }
        public IList<GoldDetailType> GoldEvents { get; set; }
        public IList<ExperienceDetailType> ExperienceEvents { get; set; }
        public IList<HealDetailType> HealEvents { get; set; }
        public IList<HeroDamageDetailType> HeroDamageEvents { get; set; }
        public IList<TowerDamageDetailType> TowerDamageEvents { get; set; }
        public IList<InventoryType> InventoryEvents { get; set; }
        public IList<ItemPurchaseType> PurchaseEvents { get; set; }
        public IList<BuyBackDetailType> BuyBackEvents { get; set; }
        public IList<StreakEventType> StreakEvents { get; set; }
        public IList<PlayerRuneDetailType> RuneEvents { get; set; }
        public IList<SpiritBearInventoryType> SpiritBearInventoryEvents { get; set; }
    }
}
