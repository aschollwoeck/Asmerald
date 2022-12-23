using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.SQLite;

namespace Asmerald.SQLite
{
    public static partial class AsmeraldOrExtensions
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
