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
    public partial class PlusDraftMissingLetterPlayerObjectType : IGraphQlInputObject
    {
        private InputPropertyInfo _slot;
        private InputPropertyInfo _heroId;
        private InputPropertyInfo _rank;
        private InputPropertyInfo _position;
        private InputPropertyInfo _order;
        private InputPropertyInfo _isPicking;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> Slot
        {
            get { return (QueryBuilderParameter<int?>)_slot.Value; }
            set { _slot = new InputPropertyInfo { Name = "slot", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<short?>))]
        #endif
        public QueryBuilderParameter<short?> HeroId
        {
            get { return (QueryBuilderParameter<short?>)_heroId.Value; }
            set { _heroId = new InputPropertyInfo { Name = "heroId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> Rank
        {
            get { return (QueryBuilderParameter<int?>)_rank.Value; }
            set { _rank = new InputPropertyInfo { Name = "rank", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<MatchPlayerPositionType?>))]
        #endif
        public QueryBuilderParameter<MatchPlayerPositionType?> Position
        {
            get { return (QueryBuilderParameter<MatchPlayerPositionType?>)_position.Value; }
            set { _position = new InputPropertyInfo { Name = "position", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<byte?>))]
        #endif
        public QueryBuilderParameter<byte?> Order
        {
            get { return (QueryBuilderParameter<byte?>)_order.Value; }
            set { _order = new InputPropertyInfo { Name = "order", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsPicking
        {
            get { return (QueryBuilderParameter<bool?>)_isPicking.Value; }
            set { _isPicking = new InputPropertyInfo { Name = "isPicking", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_slot.Name != null) yield return _slot;
            if (_heroId.Name != null) yield return _heroId;
            if (_rank.Name != null) yield return _rank;
            if (_position.Name != null) yield return _position;
            if (_order.Name != null) yield return _order;
            if (_isPicking.Name != null) yield return _isPicking;
        }
    }
}
