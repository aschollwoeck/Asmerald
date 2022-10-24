using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class OrGroupStatement : ConditionalGroupStatement
    {
        public OrGroupStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }

        public OrGroupStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
        }
    }
}
