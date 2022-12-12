using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements
{
    public class AndGroupStatement : ConditionalGroupStatement
    {
        public AndGroupStatement()
        {

        }
        public AndGroupStatement(ConditionalExpression conditionalExpression)
            : base(conditionalExpression)
        {
        }

        public AndGroupStatement(ConditionalGroupStatement conditionalGroupStatement)
        {
            this.conditionalStatements = new List<ConditionalStatement>(conditionalGroupStatement.conditionalStatements);
            this.conditionalGroupStatements = new List<ConditionalGroupStatement>(conditionalGroupStatement.conditionalGroupStatements);
        }
    }
}
