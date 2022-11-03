using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlAbortExtensions
    {
        public static AbortStatement Abort(this InsertOrStatement stmt)
        {
            return new AbortStatement(stmt.QueryBuilder);
        }
        public static UpdateAbortStatement<T> Abort<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateAbortStatement<T>(stmt.QueryBuilder);
        }
    }
}
