using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class SingularConditionalExpression : ConditionalExpression
    {
        public SingularConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
