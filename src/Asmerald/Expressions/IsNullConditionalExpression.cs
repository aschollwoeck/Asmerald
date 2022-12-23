using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class IsNullConditionalExpression : EmptyConditionalExpression
    {
        public IsNullConditionalExpression(ISelectExpression column) : base(column)
        {

        }
    }
}
