using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class MultiValueConditionalExpression : ConditionalExpression
    {
        public MultiValueConditionalExpression(IColumn column, object value) : base(column, value)
        {

        }
    }
}
