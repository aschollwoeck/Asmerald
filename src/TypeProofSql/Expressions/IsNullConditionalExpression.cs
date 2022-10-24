using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class IsNullConditionalExpression : EmptyConditionalExpression
    {
        public IsNullConditionalExpression(IColumn column) : base(column)
        {

        }
    }
}
