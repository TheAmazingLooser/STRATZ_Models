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
    public partial class FeedResponseTypeQueryBuilder : GraphQlQueryBuilder<FeedResponseTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "data", IsComplex = true, QueryBuilderType = typeof(FeedTypeQueryBuilder) },
                new FieldMetadata { Name = "count" },
                new FieldMetadata { Name = "date", IsComplex = true }
            };

        protected override string TypeName { get { return "FeedResponseType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public FeedResponseTypeQueryBuilder WithData(FeedTypeQueryBuilder feedTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("data", alias, feedTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FeedResponseTypeQueryBuilder ExceptData()
        {
            return ExceptField("data");
        }

        public FeedResponseTypeQueryBuilder WithCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("count", alias, new GraphQlDirective[] { include, skip });
        }

        public FeedResponseTypeQueryBuilder ExceptCount()
        {
            return ExceptField("count");
        }

        public FeedResponseTypeQueryBuilder WithDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("date", alias, new GraphQlDirective[] { include, skip });
        }

        public FeedResponseTypeQueryBuilder ExceptDate()
        {
            return ExceptField("date");
        }
    }
}
