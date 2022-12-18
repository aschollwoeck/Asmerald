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
