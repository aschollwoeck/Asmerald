using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class MaxFunction : IFunction
    {
        public List<ISelectExpression> X { get; private set; } = new List<ISelectExpression>();
        public MaxFunction() { }
        public MaxFunction(IEnumerable<ISelectExpression> x)
        {
            this.X.AddRange(x);
        }
    }
}
