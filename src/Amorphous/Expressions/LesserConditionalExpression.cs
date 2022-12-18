using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class LesserConditionalExpression : SingularConditionalExpression
    {
        public LesserConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
