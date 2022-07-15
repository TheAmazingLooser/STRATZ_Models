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
    public partial class PlusDraftMissingLetterRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _bans;
        private InputPropertyInfo _gameMode;
        private InputPropertyInfo _players;
        private InputPropertyInfo _gameVersionId;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> Bans
        {
            get { return (QueryBuilderParameter<IList<object>>)_bans.Value; }
            set { _bans = new InputPropertyInfo { Name = "bans", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> GameMode
        {
            get { return (QueryBuilderParameter<int?>)_gameMode.Value; }
            set { _gameMode = new InputPropertyInfo { Name = "gameMode", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<PlusDraftMissingLetterPlayerObjectType>>))]
        #endif
        public QueryBuilderParameter<IList<PlusDraftMissingLetterPlayerObjectType>> Players
        {
            get { return (QueryBuilderParameter<IList<PlusDraftMissingLetterPlayerObjectType>>)_players.Value; }
            set { _players = new InputPropertyInfo { Name = "players", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<short?>))]
        #endif
        public QueryBuilderParameter<short?> GameVersionId
        {
            get { return (QueryBuilderParameter<short?>)_gameVersionId.Value; }
            set { _gameVersionId = new InputPropertyInfo { Name = "gameVersionId", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_bans.Name != null) yield return _bans;
            if (_gameMode.Name != null) yield return _gameMode;
            if (_players.Name != null) yield return _players;
            if (_gameVersionId.Name != null) yield return _gameVersionId;
        }
    }
}
