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
    public static partial class TypeProofSqlRollbackExtensions
    {
        public static InsertRollbackStatement Rollback(this InsertOrStatement stmt)
        {
            return new InsertRollbackStatement(stmt.QueryBuilder);
        }
        public static UpdateRollbackStatement<T> Rollback<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateRollbackStatement<T>(stmt.QueryBuilder);
        }
    }
}
