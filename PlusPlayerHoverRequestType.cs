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
    public partial class PlusPlayerHoverRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _steamAccountIds;
        private InputPropertyInfo _gameModeIds;
        private InputPropertyInfo _lobbyTypeIds;
        private InputPropertyInfo _take;
        private InputPropertyInfo _shouldRadiantWin;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> SteamAccountIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_steamAccountIds.Value; }
            set { _steamAccountIds = new InputPropertyInfo { Name = "steamAccountIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> GameModeIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_gameModeIds.Value; }
            set { _gameModeIds = new InputPropertyInfo { Name = "gameModeIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> LobbyTypeIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_lobbyTypeIds.Value; }
            set { _lobbyTypeIds = new InputPropertyInfo { Name = "lobbyTypeIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> Take
        {
            get { return (QueryBuilderParameter<int?>)_take.Value; }
            set { _take = new InputPropertyInfo { Name = "take", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> ShouldRadiantWin
        {
            get { return (QueryBuilderParameter<bool?>)_shouldRadiantWin.Value; }
            set { _shouldRadiantWin = new InputPropertyInfo { Name = "shouldRadiantWin", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_steamAccountIds.Name != null) yield return _steamAccountIds;
            if (_gameModeIds.Name != null) yield return _gameModeIds;
            if (_lobbyTypeIds.Name != null) yield return _lobbyTypeIds;
            if (_take.Name != null) yield return _take;
            if (_shouldRadiantWin.Name != null) yield return _shouldRadiantWin;
        }
    }
}
