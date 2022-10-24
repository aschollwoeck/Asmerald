using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class HavingStatement : ConditionalGroupStatement
    {
        public HavingStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
            this.QueryBuilder.AddStatment(this);
        }

        public HavingStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
            //this.conditionalStatements.Add(new ConditionalStatement(queryBuilder, this, conditionalExpression));
        }
    }
}
