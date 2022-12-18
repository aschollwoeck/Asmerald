using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class GreaterConditionalExpression : SingularConditionalExpression
    {
        public GreaterConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
