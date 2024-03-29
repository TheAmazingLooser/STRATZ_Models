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
    public partial class PlusQueryQueryBuilder : GraphQlQueryBuilder<PlusQueryQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "draft", IsComplex = true, QueryBuilderType = typeof(PlusDraftTypeQueryBuilder) },
                new FieldMetadata { Name = "playerMatchHistory", IsComplex = true, QueryBuilderType = typeof(PlusHoverTypeQueryBuilder) },
                new FieldMetadata { Name = "playerHeroHighlight", IsComplex = true, QueryBuilderType = typeof(PlayerDraftHeroHighlightTypeQueryBuilder) },
                new FieldMetadata { Name = "teamHeroStatus", IsComplex = true, QueryBuilderType = typeof(PlusHeroTeamStatusDetailTypeQueryBuilder) },
                new FieldMetadata { Name = "draftMissingLetter" }
            };

        protected override string TypeName { get { return "PlusQuery"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlusQueryQueryBuilder WithDraft(PlusDraftTypeQueryBuilder plusDraftTypeQueryBuilder, QueryBuilderParameter<PlusDraftRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("draft", alias, plusDraftTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlusQueryQueryBuilder ExceptDraft()
        {
            return ExceptField("draft");
        }

        public PlusQueryQueryBuilder WithPlayerMatchHistory(PlusHoverTypeQueryBuilder plusHoverTypeQueryBuilder, QueryBuilderParameter<PlusPlayerHoverRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("playerMatchHistory", alias, plusHoverTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlusQueryQueryBuilder ExceptPlayerMatchHistory()
        {
            return ExceptField("playerMatchHistory");
        }

        public PlusQueryQueryBuilder WithPlayerHeroHighlight(PlayerDraftHeroHighlightTypeQueryBuilder playerDraftHeroHighlightTypeQueryBuilder, QueryBuilderParameter<object> steamAccountId, QueryBuilderParameter<object> heroId, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "steamAccountId", ArgumentValue = steamAccountId} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            return WithObjectField("playerHeroHighlight", alias, playerDraftHeroHighlightTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlusQueryQueryBuilder ExceptPlayerHeroHighlight()
        {
            return ExceptField("playerHeroHighlight");
        }

        public PlusQueryQueryBuilder WithTeamHeroStatus(PlusHeroTeamStatusDetailTypeQueryBuilder plusHeroTeamStatusDetailTypeQueryBuilder, QueryBuilderParameter<RankBracketBasicEnum> rankBracket, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "rankBracket", ArgumentValue = rankBracket} );
            return WithObjectField("teamHeroStatus", alias, plusHeroTeamStatusDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlusQueryQueryBuilder ExceptTeamHeroStatus()
        {
            return ExceptField("teamHeroStatus");
        }

        public PlusQueryQueryBuilder WithDraftMissingLetter(QueryBuilderParameter<PlusDraftMissingLetterRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithScalarField("draftMissingLetter", alias, new GraphQlDirective[] { include, skip }, args);
        }

        public PlusQueryQueryBuilder ExceptDraftMissingLetter()
        {
            return ExceptField("draftMissingLetter");
        }
    }
}
