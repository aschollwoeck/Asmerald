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
    public static partial class TypeProofSqlIgnoreExtensions
    {
        public static UpdateIgnore<T>Statement Ignore<T>(this UpdateOr<T> stmt)
            where T : ITable, new()
        {
            return new UpdateIgnore<T>Statement(stmt.QueryBuilder);
        }
    }
}
