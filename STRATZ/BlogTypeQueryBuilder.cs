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
    public partial class BlogTypeQueryBuilder : GraphQlQueryBuilder<BlogTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "captainJackIdentityId", IsComplex = true },
                new FieldMetadata { Name = "title" },
                new FieldMetadata { Name = "bannerImageUrl" },
                new FieldMetadata { Name = "data" },
                new FieldMetadata { Name = "liveDateTime", IsComplex = true },
                new FieldMetadata { Name = "link" }
            };

        protected override string TypeName { get { return "BlogType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public BlogTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public BlogTypeQueryBuilder WithCaptainJackIdentityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("captainJackIdentityId", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptCaptainJackIdentityId()
        {
            return ExceptField("captainJackIdentityId");
        }

        public BlogTypeQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptTitle()
        {
            return ExceptField("title");
        }

        public BlogTypeQueryBuilder WithBannerImageUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bannerImageUrl", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptBannerImageUrl()
        {
            return ExceptField("bannerImageUrl");
        }

        public BlogTypeQueryBuilder WithData(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("data", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptData()
        {
            return ExceptField("data");
        }

        public BlogTypeQueryBuilder WithLiveDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("liveDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptLiveDateTime()
        {
            return ExceptField("liveDateTime");
        }

        public BlogTypeQueryBuilder WithLink(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("link", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogTypeQueryBuilder ExceptLink()
        {
            return ExceptField("link");
        }
    }
}
