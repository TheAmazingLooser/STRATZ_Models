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
    public partial class AghanimLabRoomType
    {
        public AghanimLabMatchDifficultyEnum? Difficulty { get; set; }
        public AghanimLabDepthListEncounterEnum? EncounterId { get; set; }
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
