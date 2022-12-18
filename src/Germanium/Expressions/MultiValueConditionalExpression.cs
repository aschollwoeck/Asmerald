using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class MultiValueConditionalExpression : ConditionalExpression
    {
        public MultiValueConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
