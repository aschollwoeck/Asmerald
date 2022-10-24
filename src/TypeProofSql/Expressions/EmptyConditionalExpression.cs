using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class EmptyConditionalExpression : ConditionalExpression
    {
        public EmptyConditionalExpression(IColumn column) : base(column, "")
        {

        }
    }
}
