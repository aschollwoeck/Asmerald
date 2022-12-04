using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
