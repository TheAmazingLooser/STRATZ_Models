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
    public partial class MatchGroupByIsLeaverTypeQueryBuilder : GraphQlQueryBuilder<MatchGroupByIsLeaverTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "isLeaver" },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "avgImp" },
                new FieldMetadata { Name = "avgGoldPerMinute" },
                new FieldMetadata { Name = "avgExperiencePerMinute" },
                new FieldMetadata { Name = "avgKDA" },
                new FieldMetadata { Name = "avgKills" },
                new FieldMetadata { Name = "avgDeaths" },
                new FieldMetadata { Name = "avgAssists" },
                new FieldMetadata { Name = "avgTowerDamage" },
                new FieldMetadata { Name = "lastMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "firstMatchDateTime", IsComplex = true }
            };

        protected override string TypeName { get { return "MatchGroupByIsLeaverType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchGroupByIsLeaverTypeQueryBuilder WithIsLeaver(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isLeaver", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptIsLeaver()
        {
            return ExceptField("isLeaver");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgGoldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgGoldPerMinute()
        {
            return ExceptField("avgGoldPerMinute");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgExperiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgExperiencePerMinute()
        {
            return ExceptField("avgExperiencePerMinute");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgKda(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKDA", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgKda()
        {
            return ExceptField("avgKDA");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgKills()
        {
            return ExceptField("avgKills");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgDeaths()
        {
            return ExceptField("avgDeaths");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgAssists()
        {
            return ExceptField("avgAssists");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithAvgTowerDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgTowerDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptAvgTowerDamage()
        {
            return ExceptField("avgTowerDamage");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public MatchGroupByIsLeaverTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsLeaverTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }
    }
}
