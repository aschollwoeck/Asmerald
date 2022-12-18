using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements
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
