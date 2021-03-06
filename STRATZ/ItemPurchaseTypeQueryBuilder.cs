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
    public partial class ItemPurchaseTypeQueryBuilder : GraphQlQueryBuilder<ItemPurchaseTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "itemId", IsComplex = true }
            };

        protected override string TypeName { get { return "ItemPurchaseType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ItemPurchaseTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemPurchaseTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public ItemPurchaseTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemPurchaseTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }
    }
}
