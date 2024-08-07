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
    public partial class MatchGroupByIsPartyTypeQueryBuilder : GraphQlQueryBuilder<MatchGroupByIsPartyTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "isParty" },
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

        protected override string TypeName { get { return "MatchGroupByIsPartyType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchGroupByIsPartyTypeQueryBuilder WithIsParty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isParty", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptIsParty()
        {
            return ExceptField("isParty");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgGoldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgGoldPerMinute()
        {
            return ExceptField("avgGoldPerMinute");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgExperiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgExperiencePerMinute()
        {
            return ExceptField("avgExperiencePerMinute");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgKda(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKDA", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgKda()
        {
            return ExceptField("avgKDA");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgKills()
        {
            return ExceptField("avgKills");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgDeaths()
        {
            return ExceptField("avgDeaths");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgAssists()
        {
            return ExceptField("avgAssists");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithAvgTowerDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgTowerDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptAvgTowerDamage()
        {
            return ExceptField("avgTowerDamage");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public MatchGroupByIsPartyTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsPartyTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }
    }
}
