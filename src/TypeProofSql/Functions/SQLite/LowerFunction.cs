using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions.Functions.SQLite
{
    public class LowerFunction
    {
        public IExpression Expr { get; private set; }

        public LowerFunction(IExpression expression)
        {
            this.Expr = expression;
        }
    }
}
