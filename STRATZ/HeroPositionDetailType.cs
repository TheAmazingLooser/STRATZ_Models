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
    public partial class HeroPositionDetailType
    {
        public MatchPlayerPositionType? Position { get; set; }
        public long? MatchCount { get; set; }
        public long? WinCount { get; set; }
        public decimal? Kills { get; set; }
        public decimal? Deaths { get; set; }
        public decimal? Assists { get; set; }
        public decimal? Cs { get; set; }
        public decimal? Dn { get; set; }
        public decimal? HeroDamage { get; set; }
        public decimal? TowerDamage { get; set; }
    }
}
