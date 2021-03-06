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
    public partial class DotaNextWithAllyTypeQueryBuilder : GraphQlQueryBuilder<DotaNextWithAllyTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "lifetimeMatchCount" },
                new FieldMetadata { Name = "lifetimeWinMatchCount" }
            };

        protected override string TypeName { get { return "DotaNextWithAllyType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public DotaNextWithAllyTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public DotaNextWithAllyTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public DotaNextWithAllyTypeQueryBuilder WithLifetimeMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lifetimeMatchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public DotaNextWithAllyTypeQueryBuilder ExceptLifetimeMatchCount()
        {
            return ExceptField("lifetimeMatchCount");
        }

        public DotaNextWithAllyTypeQueryBuilder WithLifetimeWinMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lifetimeWinMatchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public DotaNextWithAllyTypeQueryBuilder ExceptLifetimeWinMatchCount()
        {
            return ExceptField("lifetimeWinMatchCount");
        }
    }
}
