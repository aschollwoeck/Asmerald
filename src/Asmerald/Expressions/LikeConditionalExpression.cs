using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class LikeConditionalExpression : SingularConditionalExpression
    {
        public LikeConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
