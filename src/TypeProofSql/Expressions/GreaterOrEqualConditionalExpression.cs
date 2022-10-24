using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class GreaterOrEqualConditionalExpression : SingularConditionalExpression
    {
        public GreaterOrEqualConditionalExpression(IColumn column, object value) : base(column, value)
        {

        }
    }
}
