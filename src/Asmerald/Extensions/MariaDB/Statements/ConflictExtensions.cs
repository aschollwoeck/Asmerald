using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MariaDB;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldConflictExtensions
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
