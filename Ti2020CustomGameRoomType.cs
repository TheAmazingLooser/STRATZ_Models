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
    public partial class Ti2020CustomGameRoomType
    {
        public Ti2020CustomGameMatchDifficultyType? Difficulty { get; set; }
        public Ti2020CustomGameDepthListEncounterType? EncounterId { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? PickCount { get; set; }
        public int? DeathCount { get; set; }
        public int? EliteMatchCount { get; set; }
        public int? EliteWinCount { get; set; }
        public int? ElitePickCount { get; set; }
        public int? EliteDeathCount { get; set; }
    }
}
