using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class GreaterOrEqualConditionalExpression : SingularConditionalExpression
    {
        public GreaterOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
