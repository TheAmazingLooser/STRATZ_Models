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
    public partial class MatchPlayerStatsKillEventType
    {
        public int? Time { get; set; }
        public int? Target { get; set; }
        public int? ByAbility { get; set; }
        public int? ByItem { get; set; }
        public int? Gold { get; set; }
        public int? Xp { get; set; }
        public int? PositionX { get; set; }
        public int? PositionY { get; set; }
        public IList<int> Assist { get; set; }
        public bool? IsSolo { get; set; }
        public bool? IsGank { get; set; }
        public bool? IsInvisible { get; set; }
        public bool? IsSmoke { get; set; }
        public bool? IsTpRecently { get; set; }
    }
}
