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
    public partial class PlayerBattlePassResponseType
    {
        public IList<PlayerBattlePassType> Players { get; set; }
        public int? PlayerCount { get; set; }
        public int? AccountsAbove2000Count { get; set; }
        public int? AccountsAbove1000Count { get; set; }
        public int? AccountsAbove500Count { get; set; }
        public int? AccountsAbove330Count { get; set; }
        public int? AccountsAbove275Count { get; set; }
        public int? AccountsAbove225Count { get; set; }
        public int? AccountsAbove195Count { get; set; }
        public int? AccountsAbove75Count { get; set; }
    }
}
