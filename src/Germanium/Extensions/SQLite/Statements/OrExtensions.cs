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
