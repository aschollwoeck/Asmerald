using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class LikeConditionalExpression : SingularConditionalExpression
    {
        public LikeConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
