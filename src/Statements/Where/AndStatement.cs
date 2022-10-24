using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class AndStatement : ConditionalStatement
    {
        public AndStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression) 
            : base(queryBuilder, groupStatement, conditionalExpression)
        {

        }
    }
}
