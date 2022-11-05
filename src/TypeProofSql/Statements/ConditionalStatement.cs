using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class ConditionalStatement : IStatement, IQueryBuilderContainer
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public ConditionalExpression ConditionalExpression { get; private set; }

        public ConditionalStatement(ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression)
            : this(null, groupStatement, conditionalExpression)
        {

        }

        public ConditionalStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression)
        {
            this.QueryBuilder = queryBuilder;
            this.ConditionalExpression = conditionalExpression;
            groupStatement.AddStatement(this);
        }
    }
}
