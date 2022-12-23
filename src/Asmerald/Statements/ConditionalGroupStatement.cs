using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;

namespace Asmerald.Statements
{

    public class ConditionalGroupStatement
    {
        public List<ConditionalGroupStatement> conditionalGroupStatements { get; set; } = new List<ConditionalGroupStatement>();
        public List<ConditionalStatement> conditionalStatements { get; set; } = new List<ConditionalStatement>();

        public ConditionalGroupStatement()
        {

        }

        public ConditionalGroupStatement(ConditionalExpression conditionalExpression)
        {
            this.conditionalStatements.Add(new ConditionalStatement(conditionalExpression));
        }

        public void AddGroup(ConditionalGroupStatement conditionalGroupStatement)
        {
            conditionalGroupStatements.Add(conditionalGroupStatement);
        }

        public void AddStatement(ConditionalStatement conditionalStatement)
        {
            conditionalStatements.Add(conditionalStatement);
        }
    }
}
