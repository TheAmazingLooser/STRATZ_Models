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
    public partial class ConstantQueryQueryBuilder : GraphQlQueryBuilder<ConstantQueryQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "hero", IsComplex = true, QueryBuilderType = typeof(HeroTypeQueryBuilder) },
                new FieldMetadata { Name = "heroes", IsComplex = true, QueryBuilderType = typeof(HeroTypeQueryBuilder) },
                new FieldMetadata { Name = "roles", IsComplex = true, QueryBuilderType = typeof(RoleTypeQueryBuilder) },
                new FieldMetadata { Name = "item", IsComplex = true, QueryBuilderType = typeof(ItemTypeQueryBuilder) },
                new FieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(ItemTypeQueryBuilder) },
                new FieldMetadata { Name = "ability", IsComplex = true, QueryBuilderType = typeof(AbilityTypeQueryBuilder) },
                new FieldMetadata { Name = "abilities", IsComplex = true, QueryBuilderType = typeof(AbilityTypeQueryBuilder) },
                new FieldMetadata { Name = "gameModes", IsComplex = true, QueryBuilderType = typeof(GameModeTypeQueryBuilder) },
                new FieldMetadata { Name = "lobbyTypes", IsComplex = true, QueryBuilderType = typeof(LobbyTypeTypeQueryBuilder) },
                new FieldMetadata { Name = "clusters", IsComplex = true, QueryBuilderType = typeof(ClusterTypeQueryBuilder) },
                new FieldMetadata { Name = "regions", IsComplex = true, QueryBuilderType = typeof(RegionTypeQueryBuilder) },
                new FieldMetadata { Name = "gameVersion", IsComplex = true, QueryBuilderType = typeof(GameVersionTypeQueryBuilder) },
                new FieldMetadata { Name = "gameVersions", IsComplex = true, QueryBuilderType = typeof(GameVersionTypeQueryBuilder) },
                new FieldMetadata { Name = "npc", IsComplex = true, QueryBuilderType = typeof(NpcTypeQueryBuilder) },
                new FieldMetadata { Name = "npcs", IsComplex = true, QueryBuilderType = typeof(NpcTypeQueryBuilder) },
                new FieldMetadata { Name = "patchNotes", IsComplex = true, QueryBuilderType = typeof(PatchNoteLanguageTypeQueryBuilder) },
                new FieldMetadata { Name = "customAbilities", IsComplex = true, QueryBuilderType = typeof(AbilityCustomGameTypeQueryBuilder) },
                new FieldMetadata { Name = "modifiers", IsComplex = true, QueryBuilderType = typeof(ModifierTypeQueryBuilder) },
                new FieldMetadata { Name = "proSteamAccounts", IsComplex = true, QueryBuilderType = typeof(ProSteamAccountTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "ConstantQuery"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ConstantQueryQueryBuilder WithHero(HeroTypeQueryBuilder heroTypeQueryBuilder, QueryBuilderParameter<object> id, QueryBuilderParameter<object> gameVersionId = null, QueryBuilderParameter<Language?> language = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id} );
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            if (language != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "language", ArgumentValue = language} );

            return WithObjectField("hero", alias, heroTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptHero()
        {
            return ExceptField("hero");
        }

        public ConstantQueryQueryBuilder WithHeroes(HeroTypeQueryBuilder heroTypeQueryBuilder, QueryBuilderParameter<object> gameVersionId = null, QueryBuilderParameter<Language?> language = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            if (language != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "language", ArgumentValue = language} );

            return WithObjectField("heroes", alias, heroTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptHeroes()
        {
            return ExceptField("heroes");
        }

        public ConstantQueryQueryBuilder WithRoles(RoleTypeQueryBuilder roleTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("roles", alias, roleTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptRoles()
        {
            return ExceptField("roles");
        }

        public ConstantQueryQueryBuilder WithItem(ItemTypeQueryBuilder itemTypeQueryBuilder, QueryBuilderParameter<int> id, QueryBuilderParameter<object> gameVersionId = null, QueryBuilderParameter<Language?> language = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id} );
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            if (language != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "language", ArgumentValue = language} );

            return WithObjectField("item", alias, itemTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptItem()
        {
            return ExceptField("item");
        }

        public ConstantQueryQueryBuilder WithItems(ItemTypeQueryBuilder itemTypeQueryBuilder, QueryBuilderParameter<object> gameVersionId = null, QueryBuilderParameter<Language?> language = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            if (language != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "language", ArgumentValue = language} );

            return WithObjectField("items", alias, itemTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptItems()
        {
            return ExceptField("items");
        }

        public ConstantQueryQueryBuilder WithAbility(AbilityTypeQueryBuilder abilityTypeQueryBuilder, QueryBuilderParameter<int> id, QueryBuilderParameter<object> gameVersionId = null, QueryBuilderParameter<Language?> language = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id} );
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            if (language != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "language", ArgumentValue = language} );

            return WithObjectField("ability", alias, abilityTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptAbility()
        {
            return ExceptField("ability");
        }

        public ConstantQueryQueryBuilder WithAbilities(AbilityTypeQueryBuilder abilityTypeQueryBuilder, QueryBuilderParameter<object> gameVersionId = null, QueryBuilderParameter<Language?> language = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            if (language != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "language", ArgumentValue = language} );

            return WithObjectField("abilities", alias, abilityTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptAbilities()
        {
            return ExceptField("abilities");
        }

        public ConstantQueryQueryBuilder WithGameModes(GameModeTypeQueryBuilder gameModeTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("gameModes", alias, gameModeTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptGameModes()
        {
            return ExceptField("gameModes");
        }

        public ConstantQueryQueryBuilder WithLobbyTypes(LobbyTypeTypeQueryBuilder lobbyTypeTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("lobbyTypes", alias, lobbyTypeTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptLobbyTypes()
        {
            return ExceptField("lobbyTypes");
        }

        public ConstantQueryQueryBuilder WithClusters(ClusterTypeQueryBuilder clusterTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("clusters", alias, clusterTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptClusters()
        {
            return ExceptField("clusters");
        }

        public ConstantQueryQueryBuilder WithRegions(RegionTypeQueryBuilder regionTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("regions", alias, regionTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptRegions()
        {
            return ExceptField("regions");
        }

        public ConstantQueryQueryBuilder WithGameVersion(GameVersionTypeQueryBuilder gameVersionTypeQueryBuilder, QueryBuilderParameter<object> id, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id} );
            return WithObjectField("gameVersion", alias, gameVersionTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptGameVersion()
        {
            return ExceptField("gameVersion");
        }

        public ConstantQueryQueryBuilder WithGameVersions(GameVersionTypeQueryBuilder gameVersionTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("gameVersions", alias, gameVersionTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptGameVersions()
        {
            return ExceptField("gameVersions");
        }

        public ConstantQueryQueryBuilder WithNpc(NpcTypeQueryBuilder npcTypeQueryBuilder, QueryBuilderParameter<object> id, QueryBuilderParameter<object> gameVersionId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id} );
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            return WithObjectField("npc", alias, npcTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptNpc()
        {
            return ExceptField("npc");
        }

        public ConstantQueryQueryBuilder WithNpcs(NpcTypeQueryBuilder npcTypeQueryBuilder, QueryBuilderParameter<object> gameVersionId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (gameVersionId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "gameVersionId", ArgumentValue = gameVersionId} );

            return WithObjectField("npcs", alias, npcTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptNpcs()
        {
            return ExceptField("npcs");
        }

        public ConstantQueryQueryBuilder WithPatchNotes(PatchNoteLanguageTypeQueryBuilder patchNoteLanguageTypeQueryBuilder, QueryBuilderParameter<Language?> languageId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (languageId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "languageId", ArgumentValue = languageId} );

            return WithObjectField("patchNotes", alias, patchNoteLanguageTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptPatchNotes()
        {
            return ExceptField("patchNotes");
        }

        public ConstantQueryQueryBuilder WithCustomAbilities(AbilityCustomGameTypeQueryBuilder abilityCustomGameTypeQueryBuilder, QueryBuilderParameter<Language?> languageId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (languageId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "languageId", ArgumentValue = languageId} );

            return WithObjectField("customAbilities", alias, abilityCustomGameTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ConstantQueryQueryBuilder ExceptCustomAbilities()
        {
            return ExceptField("customAbilities");
        }

        public ConstantQueryQueryBuilder WithModifiers(ModifierTypeQueryBuilder modifierTypeQueryBuilder, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("modifiers", alias, modifierTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public ConstantQueryQueryBuilder ExceptModifiers()
        {
            return ExceptField("modifiers");
        }

        public ConstantQueryQueryBuilder WithProSteamAccounts(ProSteamAccountTypeQueryBuilder proSteamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("proSteamAccounts", alias, proSteamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ConstantQueryQueryBuilder ExceptProSteamAccounts()
        {
            return ExceptField("proSteamAccounts");
        }
    }
}
