using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class LikeConditionalExpression : SingularConditionalExpression
    {
        public LikeConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
