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
    public static partial class TypeProofSqlAbortExtensions
    {
        public static InsertAbortStatement Abort(this InsertOrStatement stmt)
        {
            return new InsertAbortStatement(stmt.QueryBuilder);
        }
        public static UpdateAbortStatement<T> Abort<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateAbortStatement<T>(stmt.QueryBuilder);
        }
    }
}
