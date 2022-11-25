using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions.Functions.SQLite
{
    public class AbsFunction
    {
        public IExpression Expr { get; private set; }

        public AbsFunction(IExpression expression)
        {
            this.Expr = expression;
        }
    }
}
