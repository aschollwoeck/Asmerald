using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
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
