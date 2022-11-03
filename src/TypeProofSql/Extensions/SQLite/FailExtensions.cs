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
    public static partial class TypeProofSqlFailExtensions
    {
        public static UpdateFail<T>Statement Fail<T>(this UpdateOr<T> stmt)
            where T : ITable, new()
        {
            return new UpdateFail<T>Statement(stmt.QueryBuilder);
        }
    }
}
