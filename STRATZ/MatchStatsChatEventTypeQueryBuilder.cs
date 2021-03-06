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
    public partial class MatchStatsChatEventTypeQueryBuilder : GraphQlQueryBuilder<MatchStatsChatEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "type" },
                new FieldMetadata { Name = "fromHeroId", IsComplex = true },
                new FieldMetadata { Name = "toHeroId", IsComplex = true },
                new FieldMetadata { Name = "value", IsComplex = true },
                new FieldMetadata { Name = "pausedTick" },
                new FieldMetadata { Name = "isRadiant" }
            };

        protected override string TypeName { get { return "MatchStatsChatEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchStatsChatEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchStatsChatEventTypeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptType()
        {
            return ExceptField("type");
        }

        public MatchStatsChatEventTypeQueryBuilder WithFromHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fromHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptFromHeroId()
        {
            return ExceptField("fromHeroId");
        }

        public MatchStatsChatEventTypeQueryBuilder WithToHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("toHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptToHeroId()
        {
            return ExceptField("toHeroId");
        }

        public MatchStatsChatEventTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }

        public MatchStatsChatEventTypeQueryBuilder WithPausedTick(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("pausedTick", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptPausedTick()
        {
            return ExceptField("pausedTick");
        }

        public MatchStatsChatEventTypeQueryBuilder WithIsRadiant(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRadiant", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsChatEventTypeQueryBuilder ExceptIsRadiant()
        {
            return ExceptField("isRadiant");
        }
    }
}
