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
    public partial class LastHitDetailTypeQueryBuilder : GraphQlQueryBuilder<LastHitDetailTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "attacker", IsComplex = true },
                new FieldMetadata { Name = "isFromIllusion" },
                new FieldMetadata { Name = "npcId", IsComplex = true },
                new FieldMetadata { Name = "byAbility", IsComplex = true },
                new FieldMetadata { Name = "byItem", IsComplex = true },
                new FieldMetadata { Name = "gold" },
                new FieldMetadata { Name = "xp" },
                new FieldMetadata { Name = "positionX" },
                new FieldMetadata { Name = "positionY" },
                new FieldMetadata { Name = "isCreep" },
                new FieldMetadata { Name = "isNeutral" },
                new FieldMetadata { Name = "isAncient" },
                new FieldMetadata { Name = "mapLocation" }
            };

        protected override string TypeName { get { return "LastHitDetailType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LastHitDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public LastHitDetailTypeQueryBuilder WithAttacker(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attacker", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptAttacker()
        {
            return ExceptField("attacker");
        }

        public LastHitDetailTypeQueryBuilder WithIsFromIllusion(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isFromIllusion", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptIsFromIllusion()
        {
            return ExceptField("isFromIllusion");
        }

        public LastHitDetailTypeQueryBuilder WithNpcId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("npcId", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptNpcId()
        {
            return ExceptField("npcId");
        }

        public LastHitDetailTypeQueryBuilder WithByAbility(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byAbility", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptByAbility()
        {
            return ExceptField("byAbility");
        }

        public LastHitDetailTypeQueryBuilder WithByItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byItem", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptByItem()
        {
            return ExceptField("byItem");
        }

        public LastHitDetailTypeQueryBuilder WithGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gold", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptGold()
        {
            return ExceptField("gold");
        }

        public LastHitDetailTypeQueryBuilder WithXp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("xp", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptXp()
        {
            return ExceptField("xp");
        }

        public LastHitDetailTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public LastHitDetailTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }

        public LastHitDetailTypeQueryBuilder WithIsCreep(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isCreep", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptIsCreep()
        {
            return ExceptField("isCreep");
        }

        public LastHitDetailTypeQueryBuilder WithIsNeutral(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isNeutral", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptIsNeutral()
        {
            return ExceptField("isNeutral");
        }

        public LastHitDetailTypeQueryBuilder WithIsAncient(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isAncient", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptIsAncient()
        {
            return ExceptField("isAncient");
        }

        public LastHitDetailTypeQueryBuilder WithMapLocation(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mapLocation", alias, new GraphQlDirective[] { include, skip });
        }

        public LastHitDetailTypeQueryBuilder ExceptMapLocation()
        {
            return ExceptField("mapLocation");
        }
    }
}
