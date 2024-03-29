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
    public partial class RoshMutationQueryBuilder : GraphQlQueryBuilder<RoshMutationQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "create", IsComplex = true },
                new FieldMetadata { Name = "update" }
            };

        protected override string TypeName { get { return "ROSHMutation"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public RoshMutationQueryBuilder WithCreate(QueryBuilderParameter<RoshDifficultyEnum> difficulty, QueryBuilderParameter<RankBracket> bracket, QueryBuilderParameter<bool> isUserRadiant, QueryBuilderParameter<bool> isRadiantFirstPick, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "difficulty", ArgumentValue = difficulty} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bracket", ArgumentValue = bracket} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "isUserRadiant", ArgumentValue = isUserRadiant} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "isRadiantFirstPick", ArgumentValue = isRadiantFirstPick} );
            return WithScalarField("create", alias, new GraphQlDirective[] { include, skip }, args);
        }

        public RoshMutationQueryBuilder ExceptCreate()
        {
            return ExceptField("create");
        }

        public RoshMutationQueryBuilder WithUpdate(QueryBuilderParameter<object> matchId, QueryBuilderParameter<decimal> score, QueryBuilderParameter<bool> didUserWin, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "matchId", ArgumentValue = matchId} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "score", ArgumentValue = score} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "didUserWin", ArgumentValue = didUserWin} );
            return WithScalarField("update", alias, new GraphQlDirective[] { include, skip }, args);
        }

        public RoshMutationQueryBuilder ExceptUpdate()
        {
            return ExceptField("update");
        }
    }
}
