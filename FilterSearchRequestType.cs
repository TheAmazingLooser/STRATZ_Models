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
    public partial class FilterSearchRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _query;
        private InputPropertyInfo _searchType;
        private InputPropertyInfo _minimumRank;
        private InputPropertyInfo _maximumRank;
        private InputPropertyInfo _lastMatchPlayedAgo;
        private InputPropertyInfo _leaderboardRegionIds;
        private InputPropertyInfo _leagueTierIds;
        private InputPropertyInfo _teamIsPro;
        private InputPropertyInfo _take;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        #endif
        public QueryBuilderParameter<string> Query
        {
            get { return (QueryBuilderParameter<string>)_query.Value; }
            set { _query = new InputPropertyInfo { Name = "query", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<Search>>))]
        #endif
        public QueryBuilderParameter<IList<Search>> SearchType
        {
            get { return (QueryBuilderParameter<IList<Search>>)_searchType.Value; }
            set { _searchType = new InputPropertyInfo { Name = "searchType", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MinimumRank
        {
            get { return (QueryBuilderParameter<int?>)_minimumRank.Value; }
            set { _minimumRank = new InputPropertyInfo { Name = "minimumRank", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MaximumRank
        {
            get { return (QueryBuilderParameter<int?>)_maximumRank.Value; }
            set { _maximumRank = new InputPropertyInfo { Name = "maximumRank", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> LastMatchPlayedAgo
        {
            get { return (QueryBuilderParameter<long?>)_lastMatchPlayedAgo.Value; }
            set { _lastMatchPlayedAgo = new InputPropertyInfo { Name = "lastMatchPlayedAgo", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<object>>))]
        #endif
        public QueryBuilderParameter<IList<object>> LeaderboardRegionIds
        {
            get { return (QueryBuilderParameter<IList<object>>)_leaderboardRegionIds.Value; }
            set { _leaderboardRegionIds = new InputPropertyInfo { Name = "leaderboardRegionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<IList<LeagueTier>>))]
        #endif
        public QueryBuilderParameter<IList<LeagueTier>> LeagueTierIds
        {
            get { return (QueryBuilderParameter<IList<LeagueTier>>)_leagueTierIds.Value; }
            set { _leagueTierIds = new InputPropertyInfo { Name = "leagueTierIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> TeamIsPro
        {
            get { return (QueryBuilderParameter<bool?>)_teamIsPro.Value; }
            set { _teamIsPro = new InputPropertyInfo { Name = "teamIsPro", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> Take
        {
            get { return (QueryBuilderParameter<int?>)_take.Value; }
            set { _take = new InputPropertyInfo { Name = "take", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_query.Name != null) yield return _query;
            if (_searchType.Name != null) yield return _searchType;
            if (_minimumRank.Name != null) yield return _minimumRank;
            if (_maximumRank.Name != null) yield return _maximumRank;
            if (_lastMatchPlayedAgo.Name != null) yield return _lastMatchPlayedAgo;
            if (_leaderboardRegionIds.Name != null) yield return _leaderboardRegionIds;
            if (_leagueTierIds.Name != null) yield return _leagueTierIds;
            if (_teamIsPro.Name != null) yield return _teamIsPro;
            if (_take.Name != null) yield return _take;
        }
    }
}
