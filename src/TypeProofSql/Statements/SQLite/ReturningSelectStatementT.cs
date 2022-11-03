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
    public class ReturningSelectStatement<T> : InsertSelectStatement
        where T : ITable, new()
    {
        public ReturningSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn<T>> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
