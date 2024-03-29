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
    public partial class HeroStatTypeQueryBuilder : GraphQlQueryBuilder<HeroStatTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "enabled" },
                new FieldMetadata { Name = "heroUnlockOrder" },
                new FieldMetadata { Name = "team" },
                new FieldMetadata { Name = "cMEnabled" },
                new FieldMetadata { Name = "newPlayerEnabled" },
                new FieldMetadata { Name = "attackType" },
                new FieldMetadata { Name = "startingArmor" },
                new FieldMetadata { Name = "startingMagicArmor" },
                new FieldMetadata { Name = "startingDamageMin" },
                new FieldMetadata { Name = "startingDamageMax" },
                new FieldMetadata { Name = "attackRate" },
                new FieldMetadata { Name = "attackAnimationPoint" },
                new FieldMetadata { Name = "attackAcquisitionRange" },
                new FieldMetadata { Name = "attackRange" },
                new FieldMetadata { Name = "primaryAttribute" },
                new FieldMetadata { Name = "strengthBase" },
                new FieldMetadata { Name = "strengthGain" },
                new FieldMetadata { Name = "intelligenceBase" },
                new FieldMetadata { Name = "intelligenceGain" },
                new FieldMetadata { Name = "agilityBase" },
                new FieldMetadata { Name = "agilityGain" },
                new FieldMetadata { Name = "hpRegen" },
                new FieldMetadata { Name = "mpRegen" },
                new FieldMetadata { Name = "moveSpeed" },
                new FieldMetadata { Name = "moveTurnRate" },
                new FieldMetadata { Name = "hpBarOffset" },
                new FieldMetadata { Name = "visionDaytimeRange" },
                new FieldMetadata { Name = "visionNighttimeRange" },
                new FieldMetadata { Name = "complexity", IsComplex = true },
                new FieldMetadata { Name = "primaryAttributeEnum" }
            };

        protected override string TypeName { get { return "HeroStatType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroStatTypeQueryBuilder WithEnabled(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("enabled", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptEnabled()
        {
            return ExceptField("enabled");
        }

        public HeroStatTypeQueryBuilder WithHeroUnlockOrder(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroUnlockOrder", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptHeroUnlockOrder()
        {
            return ExceptField("heroUnlockOrder");
        }

        public HeroStatTypeQueryBuilder WithTeam(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("team", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptTeam()
        {
            return ExceptField("team");
        }

        public HeroStatTypeQueryBuilder WithCmEnabled(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cMEnabled", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptCmEnabled()
        {
            return ExceptField("cMEnabled");
        }

        public HeroStatTypeQueryBuilder WithNewPlayerEnabled(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("newPlayerEnabled", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptNewPlayerEnabled()
        {
            return ExceptField("newPlayerEnabled");
        }

        public HeroStatTypeQueryBuilder WithAttackType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackType", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAttackType()
        {
            return ExceptField("attackType");
        }

        public HeroStatTypeQueryBuilder WithStartingArmor(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startingArmor", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptStartingArmor()
        {
            return ExceptField("startingArmor");
        }

        public HeroStatTypeQueryBuilder WithStartingMagicArmor(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startingMagicArmor", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptStartingMagicArmor()
        {
            return ExceptField("startingMagicArmor");
        }

        public HeroStatTypeQueryBuilder WithStartingDamageMin(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startingDamageMin", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptStartingDamageMin()
        {
            return ExceptField("startingDamageMin");
        }

        public HeroStatTypeQueryBuilder WithStartingDamageMax(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startingDamageMax", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptStartingDamageMax()
        {
            return ExceptField("startingDamageMax");
        }

        public HeroStatTypeQueryBuilder WithAttackRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackRate", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAttackRate()
        {
            return ExceptField("attackRate");
        }

        public HeroStatTypeQueryBuilder WithAttackAnimationPoint(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackAnimationPoint", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAttackAnimationPoint()
        {
            return ExceptField("attackAnimationPoint");
        }

        public HeroStatTypeQueryBuilder WithAttackAcquisitionRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackAcquisitionRange", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAttackAcquisitionRange()
        {
            return ExceptField("attackAcquisitionRange");
        }

        public HeroStatTypeQueryBuilder WithAttackRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackRange", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAttackRange()
        {
            return ExceptField("attackRange");
        }

        public HeroStatTypeQueryBuilder WithPrimaryAttribute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("primaryAttribute", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptPrimaryAttribute()
        {
            return ExceptField("primaryAttribute");
        }

        public HeroStatTypeQueryBuilder WithStrengthBase(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("strengthBase", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptStrengthBase()
        {
            return ExceptField("strengthBase");
        }

        public HeroStatTypeQueryBuilder WithStrengthGain(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("strengthGain", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptStrengthGain()
        {
            return ExceptField("strengthGain");
        }

        public HeroStatTypeQueryBuilder WithIntelligenceBase(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("intelligenceBase", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptIntelligenceBase()
        {
            return ExceptField("intelligenceBase");
        }

        public HeroStatTypeQueryBuilder WithIntelligenceGain(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("intelligenceGain", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptIntelligenceGain()
        {
            return ExceptField("intelligenceGain");
        }

        public HeroStatTypeQueryBuilder WithAgilityBase(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("agilityBase", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAgilityBase()
        {
            return ExceptField("agilityBase");
        }

        public HeroStatTypeQueryBuilder WithAgilityGain(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("agilityGain", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptAgilityGain()
        {
            return ExceptField("agilityGain");
        }

        public HeroStatTypeQueryBuilder WithHpRegen(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hpRegen", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptHpRegen()
        {
            return ExceptField("hpRegen");
        }

        public HeroStatTypeQueryBuilder WithMpRegen(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mpRegen", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptMpRegen()
        {
            return ExceptField("mpRegen");
        }

        public HeroStatTypeQueryBuilder WithMoveSpeed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("moveSpeed", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptMoveSpeed()
        {
            return ExceptField("moveSpeed");
        }

        public HeroStatTypeQueryBuilder WithMoveTurnRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("moveTurnRate", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptMoveTurnRate()
        {
            return ExceptField("moveTurnRate");
        }

        public HeroStatTypeQueryBuilder WithHpBarOffset(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hpBarOffset", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptHpBarOffset()
        {
            return ExceptField("hpBarOffset");
        }

        public HeroStatTypeQueryBuilder WithVisionDaytimeRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("visionDaytimeRange", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptVisionDaytimeRange()
        {
            return ExceptField("visionDaytimeRange");
        }

        public HeroStatTypeQueryBuilder WithVisionNighttimeRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("visionNighttimeRange", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptVisionNighttimeRange()
        {
            return ExceptField("visionNighttimeRange");
        }

        public HeroStatTypeQueryBuilder WithComplexity(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("complexity", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptComplexity()
        {
            return ExceptField("complexity");
        }

        public HeroStatTypeQueryBuilder WithPrimaryAttributeEnum(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("primaryAttributeEnum", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatTypeQueryBuilder ExceptPrimaryAttributeEnum()
        {
            return ExceptField("primaryAttributeEnum");
        }
    }
}
