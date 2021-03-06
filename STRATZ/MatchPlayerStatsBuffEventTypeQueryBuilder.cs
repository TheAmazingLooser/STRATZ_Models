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
    public partial class MatchPlayerStatsBuffEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerStatsBuffEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "abilityId" },
                new FieldMetadata { Name = "itemId" },
                new FieldMetadata { Name = "stackCount" }
            };

        protected override string TypeName { get { return "MatchPlayerStatsBuffEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerStatsBuffEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder WithAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("abilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder ExceptAbilityId()
        {
            return ExceptField("abilityId");
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder WithStackCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stackCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsBuffEventTypeQueryBuilder ExceptStackCount()
        {
            return ExceptField("stackCount");
        }
    }
}
