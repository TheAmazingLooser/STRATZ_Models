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
    public partial class MatchGroupByTotalKillsTypeQueryBuilder : GraphQlQueryBuilder<MatchGroupByTotalKillsTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "totalKills", IsComplex = true },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "avgImp" },
                new FieldMetadata { Name = "avgGoldPerMinute" },
                new FieldMetadata { Name = "avgExperiencePerMinute" },
                new FieldMetadata { Name = "avgKDA" },
                new FieldMetadata { Name = "avgKills" },
                new FieldMetadata { Name = "avgDeaths" },
                new FieldMetadata { Name = "avgAssists" },
                new FieldMetadata { Name = "lastMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "firstMatchDateTime", IsComplex = true }
            };

        protected override string TypeName { get { return "MatchGroupByTotalKillsType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchGroupByTotalKillsTypeQueryBuilder WithTotalKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("totalKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptTotalKills()
        {
            return ExceptField("totalKills");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgGoldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgGoldPerMinute()
        {
            return ExceptField("avgGoldPerMinute");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgExperiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgExperiencePerMinute()
        {
            return ExceptField("avgExperiencePerMinute");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgKda(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKDA", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgKda()
        {
            return ExceptField("avgKDA");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgKills()
        {
            return ExceptField("avgKills");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgDeaths()
        {
            return ExceptField("avgDeaths");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithAvgAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptAvgAssists()
        {
            return ExceptField("avgAssists");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public MatchGroupByTotalKillsTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByTotalKillsTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }
    }
}