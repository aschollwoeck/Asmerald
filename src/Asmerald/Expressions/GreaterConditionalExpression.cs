using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class GreaterConditionalExpression : SingularConditionalExpression
    {
        public GreaterConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
