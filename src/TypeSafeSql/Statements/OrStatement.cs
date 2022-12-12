using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements
{
    public class OrStatement : ConditionalStatement
    {
        public OrStatement(ConditionalExpression conditionalExpression)
            : base(conditionalExpression)
        {
        }
    }
}
