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
