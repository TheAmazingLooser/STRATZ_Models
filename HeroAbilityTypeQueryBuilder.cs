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
    public partial class HeroAbilityTypeQueryBuilder : GraphQlQueryBuilder<HeroAbilityTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "slot", IsComplex = true },
                new FieldMetadata { Name = "gameVersionId", IsComplex = true },
                new FieldMetadata { Name = "abilityId", IsComplex = true },
                new FieldMetadata { Name = "ability", IsComplex = true, QueryBuilderType = typeof(AbilityTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "HeroAbilityType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroAbilityTypeQueryBuilder WithSlot(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("slot", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityTypeQueryBuilder ExceptSlot()
        {
            return ExceptField("slot");
        }

        public HeroAbilityTypeQueryBuilder WithGameVersionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameVersionId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityTypeQueryBuilder ExceptGameVersionId()
        {
            return ExceptField("gameVersionId");
        }

        public HeroAbilityTypeQueryBuilder WithAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("abilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityTypeQueryBuilder ExceptAbilityId()
        {
            return ExceptField("abilityId");
        }

        public HeroAbilityTypeQueryBuilder WithAbility(AbilityTypeQueryBuilder abilityTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("ability", alias, abilityTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroAbilityTypeQueryBuilder ExceptAbility()
        {
            return ExceptField("ability");
        }
    }
}
