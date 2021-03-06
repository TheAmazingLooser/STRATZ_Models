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
    public partial class HeroItemStartingPurchaseObjectTypeQueryBuilder : GraphQlQueryBuilder<HeroItemStartingPurchaseObjectTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "itemId" },
                new FieldMetadata { Name = "instance" },
                new FieldMetadata { Name = "wasGiven" },
                new FieldMetadata { Name = "count", IsComplex = true },
                new FieldMetadata { Name = "wins", IsComplex = true },
                new FieldMetadata { Name = "winsAverage", IsComplex = true }
            };

        protected override string TypeName { get { return "HeroItemStartingPurchaseObjectType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroItemStartingPurchaseObjectTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder WithInstance(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("instance", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder ExceptInstance()
        {
            return ExceptField("instance");
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder WithWasGiven(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wasGiven", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder ExceptWasGiven()
        {
            return ExceptField("wasGiven");
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder WithCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("count", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder ExceptCount()
        {
            return ExceptField("count");
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder WithWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wins", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder ExceptWins()
        {
            return ExceptField("wins");
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder WithWinsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemStartingPurchaseObjectTypeQueryBuilder ExceptWinsAverage()
        {
            return ExceptField("winsAverage");
        }
    }
}
