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
    public partial class MatchesMonthTypeQueryBuilder : GraphQlQueryBuilder<MatchesMonthTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "month", IsComplex = true },
                new FieldMetadata { Name = "matchCount" }
            };

        protected override string TypeName { get { return "MatchesMonthType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchesMonthTypeQueryBuilder WithMonth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("month", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchesMonthTypeQueryBuilder ExceptMonth()
        {
            return ExceptField("month");
        }

        public MatchesMonthTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchesMonthTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }
    }
}
