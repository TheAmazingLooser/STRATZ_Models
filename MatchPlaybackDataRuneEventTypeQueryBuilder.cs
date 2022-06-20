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
    public partial class MatchPlaybackDataRuneEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlaybackDataRuneEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "indexId" },
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "positionX" },
                new FieldMetadata { Name = "positionY" },
                new FieldMetadata { Name = "fromPlayer" },
                new FieldMetadata { Name = "location" },
                new FieldMetadata { Name = "rune" },
                new FieldMetadata { Name = "action" }
            };

        protected override string TypeName { get { return "MatchPlaybackDataRuneEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithIndexId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("indexId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptIndexId()
        {
            return ExceptField("indexId");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithFromPlayer(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fromPlayer", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptFromPlayer()
        {
            return ExceptField("fromPlayer");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithLocation(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("location", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptLocation()
        {
            return ExceptField("location");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithRune(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rune", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptRune()
        {
            return ExceptField("rune");
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder WithAction(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("action", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataRuneEventTypeQueryBuilder ExceptAction()
        {
            return ExceptField("action");
        }
    }
}
