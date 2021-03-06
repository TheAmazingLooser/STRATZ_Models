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
    public partial class MatchPlaybackDataCourierEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlaybackDataCourierEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id" },
                new FieldMetadata { Name = "ownerHero" },
                new FieldMetadata { Name = "isRadiant" },
                new FieldMetadata { Name = "events", IsComplex = true, QueryBuilderType = typeof(MatchplaybackDataCourierEventObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchPlaybackDataCourierEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlaybackDataCourierEventTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder WithOwnerHero(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("ownerHero", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder ExceptOwnerHero()
        {
            return ExceptField("ownerHero");
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder WithIsRadiant(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRadiant", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder ExceptIsRadiant()
        {
            return ExceptField("isRadiant");
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder WithEvents(MatchplaybackDataCourierEventObjectTypeQueryBuilder matchplaybackDataCourierEventObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("events", alias, matchplaybackDataCourierEventObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataCourierEventTypeQueryBuilder ExceptEvents()
        {
            return ExceptField("events");
        }
    }
}
