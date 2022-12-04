using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlReplaceExtensions
    {
        public static InsertReplaceStatement Replace(this SQLiteDSLContext stmt)
        {
            return new InsertReplaceStatement(stmt.QueryBuilder);
        }
        public static InsertReplaceStatement Replace(this InsertOrStatement stmt)
        {
            return new InsertReplaceStatement(stmt.QueryBuilder);
        }
        public static UpdateReplaceStatement<T> Replace<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateReplaceStatement<T>(stmt.QueryBuilder);
        }
    }
}
