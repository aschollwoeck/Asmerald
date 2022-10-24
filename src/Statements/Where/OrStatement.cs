using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class OrStatement : ConditionalStatement
    {
        public OrStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression) 
            : base(queryBuilder, groupStatement, conditionalExpression)
        {

        }
    }
}
