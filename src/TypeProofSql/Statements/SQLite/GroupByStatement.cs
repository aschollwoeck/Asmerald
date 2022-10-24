using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;

namespace TypeProofSql.Statements.SQLite
{
    public class GroupByStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<IColumn> GroupByColumns { get; private set; } = new List<IColumn>();
        public GroupByStatement(IQueryBuilder queryBuilder, IEnumerable<IColumn> groupByColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.GroupByColumns.AddRange(groupByColumns);
        }
    }
}
