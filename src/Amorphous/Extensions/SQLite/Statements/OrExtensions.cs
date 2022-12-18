using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
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
