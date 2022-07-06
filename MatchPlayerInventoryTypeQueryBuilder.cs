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
    public partial class MatchPlayerInventoryTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerInventoryTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "item0", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "item1", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "item2", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "item3", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "item4", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "item5", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "backPack0", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "backPack1", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "backPack2", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "neutral0", IsComplex = true, QueryBuilderType = typeof(MatchPlayerInventoryObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchPlayerInventoryType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerInventoryTypeQueryBuilder WithItem0(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item0", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptItem0()
        {
            return ExceptField("item0");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithItem1(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item1", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptItem1()
        {
            return ExceptField("item1");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithItem2(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item2", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptItem2()
        {
            return ExceptField("item2");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithItem3(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item3", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptItem3()
        {
            return ExceptField("item3");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithItem4(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item4", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptItem4()
        {
            return ExceptField("item4");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithItem5(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item5", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptItem5()
        {
            return ExceptField("item5");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithBackPack0(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("backPack0", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptBackPack0()
        {
            return ExceptField("backPack0");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithBackPack1(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("backPack1", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptBackPack1()
        {
            return ExceptField("backPack1");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithBackPack2(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("backPack2", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptBackPack2()
        {
            return ExceptField("backPack2");
        }

        public MatchPlayerInventoryTypeQueryBuilder WithNeutral0(MatchPlayerInventoryObjectTypeQueryBuilder matchPlayerInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("neutral0", alias, matchPlayerInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerInventoryTypeQueryBuilder ExceptNeutral0()
        {
            return ExceptField("neutral0");
        }
    }
}
