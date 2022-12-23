using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class MultiValueConditionalExpression : ConditionalExpression
    {
        public MultiValueConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
