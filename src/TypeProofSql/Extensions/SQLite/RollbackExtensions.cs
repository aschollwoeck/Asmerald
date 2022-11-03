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
    public static partial class TypeProofSqlRollbackExtensions
    {
        public static RollbackStatement Rollback(this InsertOrStatement stmt)
        {
            return new RollbackStatement(stmt.QueryBuilder);
        }
        public static UpdateRollbackStatement<T> Rollback<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateRollbackStatement<T>(stmt.QueryBuilder);
        }
    }
}
