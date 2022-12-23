using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class LesserOrEqualConditionalExpression : SingularConditionalExpression
    {
        public LesserOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
