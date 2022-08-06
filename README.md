# STRATZ Models
This repository provides parsed C# models for the STRATZ.com GraphQL-API. They can be used for deserializing responses from the STRATZ-API.
All models are generated with nullable types in oder to support the nature of GraphQL and its possiblilty to select only a handfull of fields.

# Updating Models
The models are being updated daily by a program.
It is advisable to poll this repository daily in order to keep in sync with the schema and not getting unexpected API-responses.
I might add a CI to automatically release and push a NuGet-Packet once new models are available.

# QueryBuilder
The model-generator not only generates useable models but also generates so called `GraphQlQueryBuilder`.

**I highly recommend using those instead of fixed query-strings!**

The benefits of using the `GraphQlQueryBuilder` are:
* IDEs can provide you with IntelliSense (auto-completion).
* Once the models get updated, the current code of your `GraphQlQueryBuilder` will produce errors (*only incase of breaking changes*).
* It will generate correct GraphQL-Query-Strings. Every time!
* It works with necesarry and optional Query-Parameter out of the box.

# Usage
Include the models in your source-code by cloning them into it.

I would recommend doing this as a submodule[^submod] via:
```sh
git submodule add https://github.com/TheAmazingLooser/STRATZ_Models
```
To update your submodules simply use
```sh
git submodule update
```

Once included you can freely design you queries incode (use the namespace `STRATZ` to be able to use them).

This is a basic example:
```cs
//...
using STRATZ;
//...
public string GenerateGraphQL_QueryString()
{
  DotaQueryQueryBuilder dqqb =
    new DotaQueryQueryBuilder().WithConstants(new ConstantQueryQueryBuilder()
      .WithHeroes(new HeroTypeQueryBuilder().WithAllFields())
      .WithAbilities(new AbilityTypeQueryBuilder().WithAllFields())
      .WithModifiers(new ModifierTypeQueryBuilder().WithAllFields())
      .WithClusters(new ClusterTypeQueryBuilder().WithAllFields())
      .WithItems(new ItemTypeQueryBuilder().WithAllFields())
      .WithNpcs(new NpcTypeQueryBuilder().WithAllFields())
      .WithRegions(new RegionTypeQueryBuilder().WithAllFields())
      .WithRoles(new RoleTypeQueryBuilder().WithAllFields())
      .WithCustomAbilities(new AbilityCustomGameTypeQueryBuilder().WithAllFields())
      .WithGameModes(new GameModeTypeQueryBuilder().WithAllFields())
      .WithGameVersions(new GameVersionTypeQueryBuilder().WithAllFields())
      .WithLobbyTypes(new LobbyTypeTypeQueryBuilder().WithAllFields())
      .WithProSteamAccounts(new ProSteamAccountTypeQueryBuilder().WithAllFields().WithTeam(new TeamTypeQueryBuilder().WithAllFields().ExceptMatches().ExceptSeries().WithMembers(new SteamAccountTeamMemberTypeQueryBuilder().WithAllScalarFields()))));
  return dqqb.Build();
}
```

[^submod]: Be sure you initialized a (atleast local) repository with `git init` in order to be able to add a submodule. 
