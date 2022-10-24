using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class GreaterConditionalExpression : SingularConditionalExpression
    {
        public GreaterConditionalExpression(IColumn column, object value) : base(column, value)
        {

        }
    }
}
