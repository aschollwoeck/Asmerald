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
    public static partial class TypeProofSqlFailExtensions
    {
        public static InsertFailStatement Fail(this InsertOrStatement stmt)
        {
            return new InsertFailStatement(stmt.QueryBuilder);
        }
        public static UpdateFailStatement<T> Fail<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateFailStatement<T>(stmt.QueryBuilder);
        }
    }
}
