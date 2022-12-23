using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class OrderByStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<IOrderByColumn> OrderByColumns { get; private set; } = new List<IOrderByColumn>();
        public OrderByStatement() { }
        public OrderByStatement(IQueryBuilder queryBuilder, IEnumerable<IOrderByColumn> orderByColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.OrderByColumns.AddRange(orderByColumns);
        }
    }
}
