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

        public ConditionalStatement()
        {

        }

        public ConditionalStatement(ConditionalExpression conditionalExpression)
        {
            this.ConditionalExpression = conditionalExpression;
        }

        public ConditionalStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : this(conditionalExpression)
        {
            this.QueryBuilder = queryBuilder;
            if(this.QueryBuilder != null)
            {
                this.QueryBuilder.AddStatment(this);
            }
        }
    }
}
