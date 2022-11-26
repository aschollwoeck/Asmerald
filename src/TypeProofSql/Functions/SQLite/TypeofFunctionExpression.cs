using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class TypeofFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public TypeofFunctionExpression() { }
        public TypeofFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }
    }
}
