using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements
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
