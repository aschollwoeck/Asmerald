using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class LesserOrEqualConditionalExpression : SingularConditionalExpression
    {
        public LesserOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
