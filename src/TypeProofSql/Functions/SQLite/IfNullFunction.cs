using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class IfNullFunction : ISelectExpression
    {
        public ISelectExpression X { get; private set; }
        public IfNullFunction() { }
        public IfNullFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
