using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class LesserOrEqualConditionalExpression : SingularConditionalExpression
    {
        public LesserOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
