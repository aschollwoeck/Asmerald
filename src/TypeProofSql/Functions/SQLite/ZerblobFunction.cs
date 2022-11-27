using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class ZerblobFunction : ISelectExpression
    {
        public ISelectExpression X { get; private set; }
        public ZerblobFunction() { }
        public ZerblobFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}