using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class NonConditionalJoinStatement : ConditionalJoinStatement
    {
        public ITable Left { get; private set; }
        public ITable Right { get; private set; }
        public NonConditionalJoinStatement() { }
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
            : base(queryBuilder, left, right)
        {
            this.Left = left;
            this.Right = right;
        }
    }
}
