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
    public partial class ItemStatType
    {
        public long? Behavior { get; set; }
        public long? UnitTargetType { get; set; }
        public long? UnitTargetTeam { get; set; }
        public long? UnitTargetFlags { get; set; }
        public byte? FightRecapLevel { get; set; }
        public IList<int> CastRange { get; set; }
        public IList<decimal> CastPoint { get; set; }
        public IList<decimal> ManaCost { get; set; }
        public IList<decimal> ChannelTime { get; set; }
        public string SharedCooldown { get; set; }
        public int? Cost { get; set; }
        public string ShopTags { get; set; }
        public string Aliases { get; set; }
        public string Quality { get; set; }
        public bool? IsSellable { get; set; }
        public bool? IsDroppable { get; set; }
        public bool? IsPurchasable { get; set; }
        public bool? IsSideShop { get; set; }
        public bool? IsStackable { get; set; }
        public bool? IsPermanent { get; set; }
        public bool? IsHideCharges { get; set; }
        public bool? IsRequiresCharges { get; set; }
        public bool? IsDisplayCharges { get; set; }
        public bool? IsSupport { get; set; }
        public bool? IsAlertable { get; set; }
        public bool? IsTempestDoubleClonable { get; set; }
        public short? StockMax { get; set; }
        public short? InitialCharges { get; set; }
        public short? InitialStock { get; set; }
        public int? StockTime { get; set; }
        public short? InitialStockTime { get; set; }
        public bool? IsRecipe { get; set; }
        public bool? NeedsComponents { get; set; }
        public short? UpgradeItem { get; set; }
        public short? UpgradeRecipe { get; set; }
        public short? ItemResult { get; set; }
        public short? NeutralItemDropTime { get; set; }
        public NeutralItemTierEnum? NeutralItemTier { get; set; }
    }
}
