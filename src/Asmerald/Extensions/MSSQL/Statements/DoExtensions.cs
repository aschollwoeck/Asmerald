using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MSSQL;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldDoExtensions
    {
        public static UpsertDoStatement Do(this ConflictStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
        public static UpsertDoStatement Do(this UpsertConflictWhereStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
        public static UpsertDoStatement Do(this UpsertConflictWhereMultiStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
        public static UpsertDoStatement Do(this UpsertConflictWhereGroupStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
        public static UpsertDoStatement Do(this UpsertConflictWhereGroupMultiStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
    }
}
