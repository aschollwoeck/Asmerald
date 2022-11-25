using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions.Functions.SQLite
{
    public class LengthFunction
    {
        public IExpression Expr { get; private set; }

        public LengthFunction(IExpression expression)
        {
            this.Expr = expression;
        }
    }
}
