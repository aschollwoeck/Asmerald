using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
