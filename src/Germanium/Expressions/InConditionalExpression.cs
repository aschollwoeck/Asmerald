using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class InConditionalExpression : MultiValueConditionalExpression
    {
        public InConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
