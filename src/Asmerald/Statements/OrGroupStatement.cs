using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements
{
    public class OrGroupStatement : ConditionalGroupStatement
    {
        public OrGroupStatement()
        {

        }
        public OrGroupStatement(ConditionalExpression conditionalExpression)
            : base(conditionalExpression)
        {
        }

        public OrGroupStatement(ConditionalGroupStatement conditionalGroupStatement)
        {
            this.conditionalStatements = new List<ConditionalStatement>(conditionalGroupStatement.conditionalStatements);
            this.conditionalGroupStatements = new List<ConditionalGroupStatement>(conditionalGroupStatement.conditionalGroupStatements);
        }
    }
}
