using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class ConditionalGroupStatement : IStatement, IQueryBuilderContainer
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ConditionalGroupStatement> conditionalGroupStatements { get; set; } = new List<ConditionalGroupStatement>();
        public List<ConditionalStatement> conditionalStatements { get; set; } = new List<ConditionalStatement>();

        public ConditionalGroupStatement()
        {
        }

        public ConditionalGroupStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
        }

        public ConditionalGroupStatement(ConditionalExpression conditionalExpression)
            : this()
        {
            this.conditionalStatements.Add(new ConditionalStatement(this, conditionalExpression));
        }

        public ConditionalGroupStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : this(queryBuilder)
        {
            this.conditionalStatements.Add(new ConditionalStatement(queryBuilder, this, conditionalExpression));
        }

        public void AddGroup(ConditionalGroupStatement conditionalGroupStatement)
        {
            conditionalGroupStatements.Add(conditionalGroupStatement);
        }

        public void AddStatement(ConditionalStatement conditionalStatement)
        {
            conditionalStatements.Add(conditionalStatement);
        }
    }
}
