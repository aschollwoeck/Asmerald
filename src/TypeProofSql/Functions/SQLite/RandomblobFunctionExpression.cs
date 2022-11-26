using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class RandomblobFunctionExpression : ISelectExpression
    {
        public int N { get; private set; }
        public RandomblobFunctionExpression() { }
        public RandomblobFunctionExpression(int n
        )
        {
            this.N = n;
        }
    }
}
