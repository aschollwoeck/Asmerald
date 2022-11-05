using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class ReturningSelectStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ISelectColumn> Columns { get; private set; } = new List<ISelectColumn>();
        public ReturningSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn> columns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Columns.AddRange(columns);
        }
    }
}
