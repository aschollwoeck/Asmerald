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
    public class InsertSelectStatement<T> : InsertSelectStatement
        where T : ITable, new()
    {
        public InsertSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn<T>> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
