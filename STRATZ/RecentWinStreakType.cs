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
    public partial class RecentWinStreakType
    {
        public long? MatchId { get; set; }
        public int? WinStreakCount { get; set; }
        public int? Status { get; set; }
        public DateTime? FirstWonMatchDateTime { get; set; }
        public DateTime? LastWonMatchDateTime { get; set; }
        public MatchType Match { get; set; }
    }
}
