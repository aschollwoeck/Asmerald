using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class GroupByStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<IColumn> GroupByColumns { get; private set; } = new List<IColumn>();
        public GroupByStatement() { }
        public GroupByStatement(IQueryBuilder queryBuilder, IEnumerable<IColumn> groupByColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.GroupByColumns.AddRange(groupByColumns);
        }
    }
}
