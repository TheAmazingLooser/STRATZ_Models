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
    public partial class HeroDamageDetailType
    {
        public int? Time { get; set; }
        public short? Attacker { get; set; }
        public short? Target { get; set; }
        public int? Value { get; set; }
        public short? ByAbility { get; set; }
        public short? ByItem { get; set; }
        public Damage? DamageType { get; set; }
        public short? FromNpc { get; set; }
        public short? ToNpc { get; set; }
        public bool? FromIllusion { get; set; }
        public bool? ToIllusion { get; set; }
        public bool? IsPhysicalAttack { get; set; }
        public bool? IsSourceMainHero { get; set; }
        public bool? IsTargetMainHero { get; set; }
    }
}
