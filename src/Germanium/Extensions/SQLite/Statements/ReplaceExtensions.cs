using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;
using Germanium.Statements.SQLite;

namespace Germanium.SQLite
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
