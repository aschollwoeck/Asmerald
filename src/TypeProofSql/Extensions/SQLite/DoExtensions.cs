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
