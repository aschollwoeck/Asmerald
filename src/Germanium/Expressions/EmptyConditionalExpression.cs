using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class EmptyConditionalExpression : ConditionalExpression
    {
        public EmptyConditionalExpression(ISelectExpression column) : base(column, "")
        {

        }
    }
}
