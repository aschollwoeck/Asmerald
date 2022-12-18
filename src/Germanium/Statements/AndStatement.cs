using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements
{
    public class AndStatement : ConditionalStatement
    {
        public AndStatement(ConditionalExpression conditionalExpression)
            : base(conditionalExpression)
        {
        }
    }
}
