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
    public partial class SteamAccountBattlePassTypeQueryBuilder : GraphQlQueryBuilder<SteamAccountBattlePassTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamId", IsComplex = true },
                new FieldMetadata { Name = "eventId", IsComplex = true },
                new FieldMetadata { Name = "level" }
            };

        protected override string TypeName { get { return "SteamAccountBattlePassType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamAccountBattlePassTypeQueryBuilder WithSteamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountBattlePassTypeQueryBuilder ExceptSteamId()
        {
            return ExceptField("steamId");
        }

        public SteamAccountBattlePassTypeQueryBuilder WithEventId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("eventId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountBattlePassTypeQueryBuilder ExceptEventId()
        {
            return ExceptField("eventId");
        }

        public SteamAccountBattlePassTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountBattlePassTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }
    }
}
