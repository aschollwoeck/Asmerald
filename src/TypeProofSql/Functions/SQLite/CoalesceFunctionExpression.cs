using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class CoalesceFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public IExpression Y { get; private set; }
        public List<IExpression> Z { get; private set; } = new List<IExpression>();
        public CoalesceFunctionExpression() { }
        public CoalesceFunctionExpression(IExpression x, IExpression y, IEnumerable<IExpression> z
        )
        {
            this.X = x;
            this.Y = y;
            this.Z.AddRange(z);
        }
    }
}
