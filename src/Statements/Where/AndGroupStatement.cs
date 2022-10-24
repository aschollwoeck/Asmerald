using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class AndGroupStatement : ConditionalGroupStatement
    {
        public AndGroupStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }

        public AndGroupStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
        }
    }
}
