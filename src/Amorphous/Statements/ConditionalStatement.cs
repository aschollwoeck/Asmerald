using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;

namespace Amorphous.Statements
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
