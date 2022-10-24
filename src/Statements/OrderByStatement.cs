using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class OrderByStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<IOrderByColumn> OrderByColumns { get; private set; } = new List<IOrderByColumn>();

        public OrderByStatement(IQueryBuilder queryBuilder, IEnumerable<IOrderByColumn> orderByColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.OrderByColumns.AddRange(orderByColumns);
            this.QueryBuilder.AddStatment(this);
        }
    }
}
