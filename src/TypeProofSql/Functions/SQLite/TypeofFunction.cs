using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class TypeofFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public TypeofFunction() { }
        public TypeofFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
