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
    public partial class MatchStatsPickBanTypeQueryBuilder : GraphQlQueryBuilder<MatchStatsPickBanTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "isPick" },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "order" },
                new FieldMetadata { Name = "bannedHeroId", IsComplex = true },
                new FieldMetadata { Name = "isRadiant" },
                new FieldMetadata { Name = "playerIndex" },
                new FieldMetadata { Name = "wasBannedSuccessfully" },
                new FieldMetadata { Name = "baseWinRate", IsComplex = true },
                new FieldMetadata { Name = "adjustedWinRate", IsComplex = true },
                new FieldMetadata { Name = "letter" }
            };

        protected override string TypeName { get { return "MatchStatsPickBanType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchStatsPickBanTypeQueryBuilder WithIsPick(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isPick", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptIsPick()
        {
            return ExceptField("isPick");
        }

        public MatchStatsPickBanTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public MatchStatsPickBanTypeQueryBuilder WithOrder(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("order", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptOrder()
        {
            return ExceptField("order");
        }

        public MatchStatsPickBanTypeQueryBuilder WithBannedHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bannedHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptBannedHeroId()
        {
            return ExceptField("bannedHeroId");
        }

        public MatchStatsPickBanTypeQueryBuilder WithIsRadiant(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRadiant", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptIsRadiant()
        {
            return ExceptField("isRadiant");
        }

        public MatchStatsPickBanTypeQueryBuilder WithPlayerIndex(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("playerIndex", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptPlayerIndex()
        {
            return ExceptField("playerIndex");
        }

        public MatchStatsPickBanTypeQueryBuilder WithWasBannedSuccessfully(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wasBannedSuccessfully", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptWasBannedSuccessfully()
        {
            return ExceptField("wasBannedSuccessfully");
        }

        public MatchStatsPickBanTypeQueryBuilder WithBaseWinRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("baseWinRate", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptBaseWinRate()
        {
            return ExceptField("baseWinRate");
        }

        public MatchStatsPickBanTypeQueryBuilder WithAdjustedWinRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("adjustedWinRate", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptAdjustedWinRate()
        {
            return ExceptField("adjustedWinRate");
        }

        public MatchStatsPickBanTypeQueryBuilder WithLetter(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("letter", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsPickBanTypeQueryBuilder ExceptLetter()
        {
            return ExceptField("letter");
        }
    }
}
