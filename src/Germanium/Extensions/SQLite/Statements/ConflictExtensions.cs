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
