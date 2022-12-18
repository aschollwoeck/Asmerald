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
    public static partial class TypeProofSqlDoExtensions
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
