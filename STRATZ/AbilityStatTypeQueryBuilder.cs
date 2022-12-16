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
    public partial class AbilityStatTypeQueryBuilder : GraphQlQueryBuilder<AbilityStatTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "abilityId", IsComplex = true },
                new FieldMetadata { Name = "type" },
                new FieldMetadata { Name = "behavior", IsComplex = true },
                new FieldMetadata { Name = "unitTargetType", IsComplex = true },
                new FieldMetadata { Name = "unitTargetTeam" },
                new FieldMetadata { Name = "unitTargetFlags", IsComplex = true },
                new FieldMetadata { Name = "unitDamageType" },
                new FieldMetadata { Name = "spellImmunity" },
                new FieldMetadata { Name = "modifierSupportValue" },
                new FieldMetadata { Name = "modifierSupportBonus", IsComplex = true },
                new FieldMetadata { Name = "isOnCastbar" },
                new FieldMetadata { Name = "isOnLearnbar" },
                new FieldMetadata { Name = "fightRecapLevel", IsComplex = true },
                new FieldMetadata { Name = "isGrantedByScepter" },
                new FieldMetadata { Name = "hasScepterUpgrade" },
                new FieldMetadata { Name = "maxLevel", IsComplex = true },
                new FieldMetadata { Name = "levelsBetweenUpgrades", IsComplex = true },
                new FieldMetadata { Name = "requiredLevel", IsComplex = true },
                new FieldMetadata { Name = "hotKeyOverride" },
                new FieldMetadata { Name = "displayAdditionalHeroes" },
                new FieldMetadata { Name = "castRange", IsComplex = true },
                new FieldMetadata { Name = "castRangeBuffer", IsComplex = true },
                new FieldMetadata { Name = "castPoint", IsComplex = true },
                new FieldMetadata { Name = "channelTime", IsComplex = true },
                new FieldMetadata { Name = "cooldown", IsComplex = true },
                new FieldMetadata { Name = "damage", IsComplex = true },
                new FieldMetadata { Name = "manaCost", IsComplex = true },
                new FieldMetadata { Name = "isUltimate" },
                new FieldMetadata { Name = "duration" },
                new FieldMetadata { Name = "charges" },
                new FieldMetadata { Name = "chargeRestoreTime" },
                new FieldMetadata { Name = "isGrantedByShard" },
                new FieldMetadata { Name = "dispellable" },
                new FieldMetadata { Name = "linkedAbilityId", IsComplex = true }
            };

        protected override string TypeName { get { return "AbilityStatType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AbilityStatTypeQueryBuilder WithAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("abilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptAbilityId()
        {
            return ExceptField("abilityId");
        }

        public AbilityStatTypeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptType()
        {
            return ExceptField("type");
        }

        public AbilityStatTypeQueryBuilder WithBehavior(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("behavior", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptBehavior()
        {
            return ExceptField("behavior");
        }

        public AbilityStatTypeQueryBuilder WithUnitTargetType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitTargetType", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptUnitTargetType()
        {
            return ExceptField("unitTargetType");
        }

        public AbilityStatTypeQueryBuilder WithUnitTargetTeam(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitTargetTeam", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptUnitTargetTeam()
        {
            return ExceptField("unitTargetTeam");
        }

        public AbilityStatTypeQueryBuilder WithUnitTargetFlags(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitTargetFlags", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptUnitTargetFlags()
        {
            return ExceptField("unitTargetFlags");
        }

        public AbilityStatTypeQueryBuilder WithUnitDamageType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitDamageType", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptUnitDamageType()
        {
            return ExceptField("unitDamageType");
        }

        public AbilityStatTypeQueryBuilder WithSpellImmunity(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("spellImmunity", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptSpellImmunity()
        {
            return ExceptField("spellImmunity");
        }

        public AbilityStatTypeQueryBuilder WithModifierSupportValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("modifierSupportValue", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptModifierSupportValue()
        {
            return ExceptField("modifierSupportValue");
        }

        public AbilityStatTypeQueryBuilder WithModifierSupportBonus(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("modifierSupportBonus", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptModifierSupportBonus()
        {
            return ExceptField("modifierSupportBonus");
        }

        public AbilityStatTypeQueryBuilder WithIsOnCastbar(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isOnCastbar", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptIsOnCastbar()
        {
            return ExceptField("isOnCastbar");
        }

        public AbilityStatTypeQueryBuilder WithIsOnLearnbar(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isOnLearnbar", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptIsOnLearnbar()
        {
            return ExceptField("isOnLearnbar");
        }

        public AbilityStatTypeQueryBuilder WithFightRecapLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fightRecapLevel", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptFightRecapLevel()
        {
            return ExceptField("fightRecapLevel");
        }

        public AbilityStatTypeQueryBuilder WithIsGrantedByScepter(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isGrantedByScepter", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptIsGrantedByScepter()
        {
            return ExceptField("isGrantedByScepter");
        }

        public AbilityStatTypeQueryBuilder WithHasScepterUpgrade(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hasScepterUpgrade", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptHasScepterUpgrade()
        {
            return ExceptField("hasScepterUpgrade");
        }

        public AbilityStatTypeQueryBuilder WithMaxLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("maxLevel", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptMaxLevel()
        {
            return ExceptField("maxLevel");
        }

        public AbilityStatTypeQueryBuilder WithLevelsBetweenUpgrades(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("levelsBetweenUpgrades", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptLevelsBetweenUpgrades()
        {
            return ExceptField("levelsBetweenUpgrades");
        }

        public AbilityStatTypeQueryBuilder WithRequiredLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("requiredLevel", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptRequiredLevel()
        {
            return ExceptField("requiredLevel");
        }

        public AbilityStatTypeQueryBuilder WithHotKeyOverride(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hotKeyOverride", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptHotKeyOverride()
        {
            return ExceptField("hotKeyOverride");
        }

        public AbilityStatTypeQueryBuilder WithDisplayAdditionalHeroes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displayAdditionalHeroes", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptDisplayAdditionalHeroes()
        {
            return ExceptField("displayAdditionalHeroes");
        }

        public AbilityStatTypeQueryBuilder WithCastRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("castRange", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptCastRange()
        {
            return ExceptField("castRange");
        }

        public AbilityStatTypeQueryBuilder WithCastRangeBuffer(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("castRangeBuffer", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptCastRangeBuffer()
        {
            return ExceptField("castRangeBuffer");
        }

        public AbilityStatTypeQueryBuilder WithCastPoint(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("castPoint", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptCastPoint()
        {
            return ExceptField("castPoint");
        }

        public AbilityStatTypeQueryBuilder WithChannelTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("channelTime", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptChannelTime()
        {
            return ExceptField("channelTime");
        }

        public AbilityStatTypeQueryBuilder WithCooldown(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cooldown", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptCooldown()
        {
            return ExceptField("cooldown");
        }

        public AbilityStatTypeQueryBuilder WithDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damage", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptDamage()
        {
            return ExceptField("damage");
        }

        public AbilityStatTypeQueryBuilder WithManaCost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("manaCost", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptManaCost()
        {
            return ExceptField("manaCost");
        }

        public AbilityStatTypeQueryBuilder WithIsUltimate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isUltimate", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptIsUltimate()
        {
            return ExceptField("isUltimate");
        }

        public AbilityStatTypeQueryBuilder WithDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("duration", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptDuration()
        {
            return ExceptField("duration");
        }

        public AbilityStatTypeQueryBuilder WithCharges(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("charges", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptCharges()
        {
            return ExceptField("charges");
        }

        public AbilityStatTypeQueryBuilder WithChargeRestoreTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("chargeRestoreTime", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptChargeRestoreTime()
        {
            return ExceptField("chargeRestoreTime");
        }

        public AbilityStatTypeQueryBuilder WithIsGrantedByShard(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isGrantedByShard", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptIsGrantedByShard()
        {
            return ExceptField("isGrantedByShard");
        }

        public AbilityStatTypeQueryBuilder WithDispellable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dispellable", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptDispellable()
        {
            return ExceptField("dispellable");
        }

        public AbilityStatTypeQueryBuilder WithLinkedAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("linkedAbilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityStatTypeQueryBuilder ExceptLinkedAbilityId()
        {
            return ExceptField("linkedAbilityId");
        }
    }
}
