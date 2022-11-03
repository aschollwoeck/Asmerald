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
        public static FailStatement Fail(this InsertOrStatement stmt)
        {
            return new FailStatement(stmt.QueryBuilder);
        }
        public static UpdateFailStatement<T> Fail<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateFailStatement<T>(stmt.QueryBuilder);
        }
    }
}
