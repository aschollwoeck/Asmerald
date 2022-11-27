using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class CoalesceFunction : ISelectExpression
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public List<ISelectExpression> Z { get; private set; } = new List<ISelectExpression>();
        public CoalesceFunction() { }
        public CoalesceFunction(ISelectExpression x, ISelectExpression y, IEnumerable<ISelectExpression> z)
        {
            this.X = x;
            this.Y = y;
            this.Z.AddRange(z);
        }
    }
}
