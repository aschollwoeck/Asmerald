using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class InConditionalExpression : MultiValueConditionalExpression
    {
        public InConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
