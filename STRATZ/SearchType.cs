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
    public partial class SearchType
    {
        public IList<SteamAccountType> Players { get; set; }
        public IList<MatchType> Matches { get; set; }
        public IList<LeagueType> Leagues { get; set; }
        public IList<TeamType> Teams { get; set; }
        public IList<SteamAccountType> ProPlayers { get; set; }
        public IList<SteamAccountType> Casters { get; set; }
        public GuildType Guild { get; set; }
        public IList<DireTideCustomGameMatchType> DireTideMatches { get; set; }
    }
}
