using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class GreaterOrEqualConditionalExpression : SingularConditionalExpression
    {
        public GreaterOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
