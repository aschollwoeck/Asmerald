using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class LikelyFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LikelyFunction() { }
        public LikelyFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
