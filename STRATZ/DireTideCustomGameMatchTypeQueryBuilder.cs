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
    public partial class DireTideCustomGameMatchTypeQueryBuilder : GraphQlQueryBuilder<DireTideCustomGameMatchTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "didRadiantWin" },
                new FieldMetadata { Name = "durationSeconds", IsComplex = true },
                new FieldMetadata { Name = "startDateTime", IsComplex = true },
                new FieldMetadata { Name = "endDateTime", IsComplex = true },
                new FieldMetadata { Name = "clusterId", IsComplex = true },
                new FieldMetadata { Name = "replaySalt", IsComplex = true },
                new FieldMetadata { Name = "candyLost", IsComplex = true },
                new FieldMetadata { Name = "candyPickedUp", IsComplex = true },
                new FieldMetadata { Name = "candyScored", IsComplex = true },
                new FieldMetadata { Name = "radiantCandyScored", IsComplex = true },
                new FieldMetadata { Name = "direCandyScored", IsComplex = true },
                new FieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(DireTideCustomGamePlayerTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "DireTideCustomGameMatchType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public DireTideCustomGameMatchTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithDidRadiantWin(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("didRadiantWin", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptDidRadiantWin()
        {
            return ExceptField("didRadiantWin");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithDurationSeconds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationSeconds", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptDurationSeconds()
        {
            return ExceptField("durationSeconds");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithStartDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptStartDateTime()
        {
            return ExceptField("startDateTime");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithEndDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("endDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptEndDateTime()
        {
            return ExceptField("endDateTime");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithClusterId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("clusterId", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptClusterId()
        {
            return ExceptField("clusterId");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithReplaySalt(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("replaySalt", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptReplaySalt()
        {
            return ExceptField("replaySalt");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithCandyLost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyLost", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptCandyLost()
        {
            return ExceptField("candyLost");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithCandyPickedUp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyPickedUp", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptCandyPickedUp()
        {
            return ExceptField("candyPickedUp");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithCandyScored(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyScored", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptCandyScored()
        {
            return ExceptField("candyScored");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithRadiantCandyScored(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("radiantCandyScored", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptRadiantCandyScored()
        {
            return ExceptField("radiantCandyScored");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithDireCandyScored(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("direCandyScored", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptDireCandyScored()
        {
            return ExceptField("direCandyScored");
        }

        public DireTideCustomGameMatchTypeQueryBuilder WithPlayers(DireTideCustomGamePlayerTypeQueryBuilder direTideCustomGamePlayerTypeQueryBuilder, QueryBuilderParameter<object> steamAccountId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (steamAccountId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "steamAccountId", ArgumentValue = steamAccountId} );

            return WithObjectField("players", alias, direTideCustomGamePlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public DireTideCustomGameMatchTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }
    }
}
