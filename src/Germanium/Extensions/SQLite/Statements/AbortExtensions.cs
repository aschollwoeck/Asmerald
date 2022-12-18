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
