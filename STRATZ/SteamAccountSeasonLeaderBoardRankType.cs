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
    public partial class SteamAccountSeasonLeaderBoardRankType
    {
        public long? SteamAccountId { get; set; }
        public byte? SeasonRankId { get; set; }
        public IList<int> ActionsPerMinute { get; set; }
        public byte? SeasonLeaderBoardDivisionId { get; set; }
        public short? Rank { get; set; }
    }
}
