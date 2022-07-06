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
    public partial class SteamApiDetailTypeQueryBuilder : GraphQlQueryBuilder<SteamApiDetailTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "isOnline" },
                new FieldMetadata { Name = "outages", IsComplex = true, QueryBuilderType = typeof(SteamApiDetailOutageTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "SteamApiDetailType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamApiDetailTypeQueryBuilder WithIsOnline(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isOnline", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamApiDetailTypeQueryBuilder ExceptIsOnline()
        {
            return ExceptField("isOnline");
        }

        public SteamApiDetailTypeQueryBuilder WithOutages(SteamApiDetailOutageTypeQueryBuilder steamApiDetailOutageTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("outages", alias, steamApiDetailOutageTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamApiDetailTypeQueryBuilder ExceptOutages()
        {
            return ExceptField("outages");
        }
    }
}
