using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements
{
    public class OrStatement : ConditionalStatement
    {
        public OrStatement(ConditionalExpression conditionalExpression)
            : base(conditionalExpression)
        {
        }
    }
}
