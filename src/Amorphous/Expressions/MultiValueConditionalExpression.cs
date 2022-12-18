using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class MultiValueConditionalExpression : ConditionalExpression
    {
        public MultiValueConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
