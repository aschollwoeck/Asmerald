using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class OnMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable TLeft { get; private set; }
        public ITable TRight { get; private set; }
        public List<(ISelectColumn left, ISelectColumn right)> On { get; private set; } = new List<(ISelectColumn left, ISelectColumn right)>();
        public OnMultiStatement() { }
        public OnMultiStatement(IQueryBuilder queryBuilder, ITable tLeft, ITable tRight, IEnumerable<(ISelectColumn left, ISelectColumn right)> on)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.TLeft = tLeft;
            this.TRight = tRight;
            this.On.AddRange(on);
        }
    }
}
