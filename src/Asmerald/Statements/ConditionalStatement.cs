using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;

namespace Asmerald.Statements
{

    public class ConditionalStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }

        public ConditionalStatement(ConditionalExpression conditionalExpression)
        {
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
