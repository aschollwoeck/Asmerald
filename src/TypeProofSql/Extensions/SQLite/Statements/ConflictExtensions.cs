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
    public static partial class TypeProofSqlConflictExtensions
    {
        public static ConflictStatement Conflict(this UpsertOnStatement stmt)
        {
            return new ConflictStatement(stmt.QueryBuilder);
        }
        public static UpsertConflictSelectColumnsStatement Conflict(this UpsertOnStatement stmt, params ISelectColumn[] columns)
        {
            return new UpsertConflictSelectColumnsStatement(stmt.QueryBuilder, columns);
        }
    }
}
