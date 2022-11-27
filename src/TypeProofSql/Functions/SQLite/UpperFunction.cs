using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class UpperFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UpperFunction() { }
        public UpperFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
