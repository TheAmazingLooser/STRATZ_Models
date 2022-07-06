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
    public partial class HeroMatchupTypeQueryBuilder : GraphQlQueryBuilder<HeroMatchupTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "advantage", IsComplex = true, QueryBuilderType = typeof(HeroDryadTypeQueryBuilder) },
                new FieldMetadata { Name = "disadvantage", IsComplex = true, QueryBuilderType = typeof(HeroDryadTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "HeroMatchupType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroMatchupTypeQueryBuilder WithAdvantage(HeroDryadTypeQueryBuilder heroDryadTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("advantage", alias, heroDryadTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroMatchupTypeQueryBuilder ExceptAdvantage()
        {
            return ExceptField("advantage");
        }

        public HeroMatchupTypeQueryBuilder WithDisadvantage(HeroDryadTypeQueryBuilder heroDryadTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("disadvantage", alias, heroDryadTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroMatchupTypeQueryBuilder ExceptDisadvantage()
        {
            return ExceptField("disadvantage");
        }
    }
}
