using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class HexFunction : ISelectExpression
    {
        public List<ISelectExpression> Z { get; private set; } = new List<ISelectExpression>();
        public HexFunction() { }
        public HexFunction(IEnumerable<ISelectExpression> z)
        {
            this.Z.AddRange(z);
        }
    }
}
