using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class LesserConditionalExpression : SingularConditionalExpression
    {
        public LesserConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
