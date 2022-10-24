using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class ConditionalExpression
    {
        public readonly IColumn Column;
        public readonly object Value;

        public ConditionalExpression(IColumn column, object value)
        {
            this.Column = column;
            this.Value = value;
        }
    }
}
