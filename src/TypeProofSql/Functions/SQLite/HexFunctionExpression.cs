using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class HexFunctionExpression : ISelectExpression
    {
        public List<IExpression> Z { get; private set; } = new List<IExpression>();
        public HexFunctionExpression() { }
        public HexFunctionExpression(IEnumerable<IExpression> z
        )
        {
            this.Z.AddRange(z);
        }
    }
}
