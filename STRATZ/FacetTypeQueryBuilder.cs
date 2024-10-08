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
    public partial class FacetTypeQueryBuilder : GraphQlQueryBuilder<FacetTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "name" },
                new FieldMetadata { Name = "color" },
                new FieldMetadata { Name = "icon" },
                new FieldMetadata { Name = "gradientId", IsComplex = true },
                new FieldMetadata { Name = "language", IsComplex = true, QueryBuilderType = typeof(FacetLanguageTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "FacetType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public FacetTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public FacetTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public FacetTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public FacetTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public FacetTypeQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        }

        public FacetTypeQueryBuilder ExceptColor()
        {
            return ExceptField("color");
        }

        public FacetTypeQueryBuilder WithIcon(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("icon", alias, new GraphQlDirective[] { include, skip });
        }

        public FacetTypeQueryBuilder ExceptIcon()
        {
            return ExceptField("icon");
        }

        public FacetTypeQueryBuilder WithGradientId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gradientId", alias, new GraphQlDirective[] { include, skip });
        }

        public FacetTypeQueryBuilder ExceptGradientId()
        {
            return ExceptField("gradientId");
        }

        public FacetTypeQueryBuilder WithLanguage(FacetLanguageTypeQueryBuilder facetLanguageTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("language", alias, facetLanguageTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FacetTypeQueryBuilder ExceptLanguage()
        {
            return ExceptField("language");
        }
    }
}
