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
    public partial class HeroItemPurchaseObjectTypeQueryBuilder : GraphQlQueryBuilder<HeroItemPurchaseObjectTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "itemId" },
                new FieldMetadata { Name = "instance" },
                new FieldMetadata { Name = "time", IsComplex = true },
                new FieldMetadata { Name = "count", IsComplex = true },
                new FieldMetadata { Name = "wins", IsComplex = true },
                new FieldMetadata { Name = "winsAverage", IsComplex = true }
            };

        protected override string TypeName { get { return "HeroItemPurchaseObjectType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroItemPurchaseObjectTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseObjectTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public HeroItemPurchaseObjectTypeQueryBuilder WithInstance(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("instance", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseObjectTypeQueryBuilder ExceptInstance()
        {
            return ExceptField("instance");
        }

        public HeroItemPurchaseObjectTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseObjectTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public HeroItemPurchaseObjectTypeQueryBuilder WithCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("count", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseObjectTypeQueryBuilder ExceptCount()
        {
            return ExceptField("count");
        }

        public HeroItemPurchaseObjectTypeQueryBuilder WithWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wins", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseObjectTypeQueryBuilder ExceptWins()
        {
            return ExceptField("wins");
        }

        public HeroItemPurchaseObjectTypeQueryBuilder WithWinsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseObjectTypeQueryBuilder ExceptWinsAverage()
        {
            return ExceptField("winsAverage");
        }
    }
}
