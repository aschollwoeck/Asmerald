using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class WhereStatement : ConditionalGroupStatement
    {
        public WhereStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
            this.QueryBuilder.AddStatment(this);
        }

        public WhereStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
            //this.conditionalStatements.Add(new ConditionalStatement(queryBuilder, this, conditionalExpression));
        }
    }
}
