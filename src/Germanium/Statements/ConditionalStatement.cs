using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Expressions;
using Germanium.QueryBuilders;

namespace Germanium.Statements
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
