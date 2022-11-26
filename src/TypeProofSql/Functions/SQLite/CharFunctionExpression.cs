using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class CharFunctionExpression : ISelectExpression
    {
        public IExpression X1 { get; private set; }
        public IExpression X2 { get; private set; }
        public List<IExpression> Xn { get; private set; } = new List<IExpression>();
        public CharFunctionExpression() { }
        public CharFunctionExpression(IExpression x1, IExpression x2, IEnumerable<IExpression> xn
        )
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Xn.AddRange(xn);
        }
    }
}
