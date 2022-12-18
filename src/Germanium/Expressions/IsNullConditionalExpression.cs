using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class IsNullConditionalExpression : EmptyConditionalExpression
    {
        public IsNullConditionalExpression(ISelectExpression column) : base(column)
        {

        }
    }
}
