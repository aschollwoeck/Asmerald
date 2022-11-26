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
    public static partial class TypeProofSqlOrExtensions
    {
        public static InsertOrStatement Or<T>(this IntoStatement<T> stmt)
            where T : ITable, new()
        {
            return new InsertOrStatement(stmt.QueryBuilder);
        }
        public static UpdateOrStatement<T> Or<T>(this UpdateStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateOrStatement<T>(stmt.QueryBuilder);
        }
    }
}
