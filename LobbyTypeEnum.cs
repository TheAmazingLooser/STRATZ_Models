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
    public enum LobbyTypeEnum
    {
        [EnumMember(Value = "UNRANKED")] Unranked,
        [EnumMember(Value = "PRACTICE")] Practice,
        [EnumMember(Value = "TOURNAMENT")] Tournament,
        [EnumMember(Value = "TUTORIAL")] Tutorial,
        [EnumMember(Value = "COOP_VS_BOTS")] CoopVsBots,
        [EnumMember(Value = "TEAM_MATCH")] TeamMatch,
        [EnumMember(Value = "SOLO_QUEUE")] SoloQueue,
        [EnumMember(Value = "RANKED")] Ranked,
        [EnumMember(Value = "SOLO_MID")] SoloMid,
        [EnumMember(Value = "BATTLE_CUP")] BattleCup,
        [EnumMember(Value = "EVENT")] Event
    }
}
