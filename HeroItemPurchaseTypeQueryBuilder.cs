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
    public partial class HeroItemPurchaseTypeQueryBuilder : GraphQlQueryBuilder<HeroItemPurchaseTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId" },
                new FieldMetadata { Name = "week" },
                new FieldMetadata { Name = "bracketBasic" },
                new FieldMetadata { Name = "position" },
                new FieldMetadata { Name = "events", IsComplex = true, QueryBuilderType = typeof(HeroItemPurchaseObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "count", IsComplex = true }
            };

        protected override string TypeName { get { return "HeroItemPurchaseType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroItemPurchaseTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroItemPurchaseTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroItemPurchaseTypeQueryBuilder WithBracketBasic(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasic", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptBracketBasic()
        {
            return ExceptField("bracketBasic");
        }

        public HeroItemPurchaseTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public HeroItemPurchaseTypeQueryBuilder WithEvents(HeroItemPurchaseObjectTypeQueryBuilder heroItemPurchaseObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("events", alias, heroItemPurchaseObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptEvents()
        {
            return ExceptField("events");
        }

        public HeroItemPurchaseTypeQueryBuilder WithCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("count", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptCount()
        {
            return ExceptField("count");
        }
    }
}
