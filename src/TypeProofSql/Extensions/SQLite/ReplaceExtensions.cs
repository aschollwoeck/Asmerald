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
    public static partial class TypeProofSqlReplaceExtensions
    {
        public static ReplaceStatement Replace(this SQLiteDSLContext stmt)
        {
            return new ReplaceStatement(stmt.QueryBuilder);
        }
        public static UpdateReplace<T>Statement Replace<T>(this UpdateOr<T> stmt)
            where T : ITable, new()
        {
            return new UpdateReplace<T>Statement(stmt.QueryBuilder);
        }
    }
}
