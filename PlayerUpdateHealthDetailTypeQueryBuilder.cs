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
    public partial class PlayerUpdateHealthDetailTypeQueryBuilder : GraphQlQueryBuilder<PlayerUpdateHealthDetailTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "hp" },
                new FieldMetadata { Name = "maxHp" },
                new FieldMetadata { Name = "mp" },
                new FieldMetadata { Name = "maxMp" }
            };

        protected override string TypeName { get { return "PlayerUpdateHealthDetailType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerUpdateHealthDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder WithHp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hp", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder ExceptHp()
        {
            return ExceptField("hp");
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder WithMaxHp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("maxHp", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder ExceptMaxHp()
        {
            return ExceptField("maxHp");
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder WithMp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mp", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder ExceptMp()
        {
            return ExceptField("mp");
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder WithMaxMp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("maxMp", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateHealthDetailTypeQueryBuilder ExceptMaxMp()
        {
            return ExceptField("maxMp");
        }
    }
}
