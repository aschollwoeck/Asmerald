using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class GroupByStatement : IStatement, IQueryBuilderContainer
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<IColumn> GroupByColumns { get; private set; } = new List<IColumn>();

        public GroupByStatement(IQueryBuilder queryBuilder, IEnumerable<IColumn> groupByColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.GroupByColumns.AddRange(groupByColumns);
            this.QueryBuilder.AddStatment(this);
        }
    }
}
