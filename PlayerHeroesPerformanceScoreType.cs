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
    public partial class PlayerHeroesPerformanceScoreType
    {
        public MatchPlayerPositionType? Id { get; set; }
        public decimal? Score { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? Imp { get; set; }
    }
}
