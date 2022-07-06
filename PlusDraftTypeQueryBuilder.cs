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
    public partial class PlusDraftTypeQueryBuilder : GraphQlQueryBuilder<PlusDraftTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "midOutcome", IsComplex = true },
                new FieldMetadata { Name = "safeOutcome", IsComplex = true },
                new FieldMetadata { Name = "offOutcome", IsComplex = true },
                new FieldMetadata { Name = "winValues", IsComplex = true },
                new FieldMetadata { Name = "durationValues", IsComplex = true },
                new FieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(PlusDraftPlayerTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "PlusDraftType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlusDraftTypeQueryBuilder WithMidOutcome(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("midOutcome", alias, new GraphQlDirective[] { include, skip });
        }

        public PlusDraftTypeQueryBuilder ExceptMidOutcome()
        {
            return ExceptField("midOutcome");
        }

        public PlusDraftTypeQueryBuilder WithSafeOutcome(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("safeOutcome", alias, new GraphQlDirective[] { include, skip });
        }

        public PlusDraftTypeQueryBuilder ExceptSafeOutcome()
        {
            return ExceptField("safeOutcome");
        }

        public PlusDraftTypeQueryBuilder WithOffOutcome(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("offOutcome", alias, new GraphQlDirective[] { include, skip });
        }

        public PlusDraftTypeQueryBuilder ExceptOffOutcome()
        {
            return ExceptField("offOutcome");
        }

        public PlusDraftTypeQueryBuilder WithWinValues(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winValues", alias, new GraphQlDirective[] { include, skip });
        }

        public PlusDraftTypeQueryBuilder ExceptWinValues()
        {
            return ExceptField("winValues");
        }

        public PlusDraftTypeQueryBuilder WithDurationValues(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationValues", alias, new GraphQlDirective[] { include, skip });
        }

        public PlusDraftTypeQueryBuilder ExceptDurationValues()
        {
            return ExceptField("durationValues");
        }

        public PlusDraftTypeQueryBuilder WithPlayers(PlusDraftPlayerTypeQueryBuilder plusDraftPlayerTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("players", alias, plusDraftPlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlusDraftTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }
    }
}
