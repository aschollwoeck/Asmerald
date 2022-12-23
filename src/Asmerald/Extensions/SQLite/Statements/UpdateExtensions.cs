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
    public static partial class AsmeraldUpdateExtensions
    {
        public static UpdateStatement<T> Update<T>(this SQLiteDSLContext stmt)
            where T : ITable, new()
        {
            return new UpdateStatement<T>(stmt.QueryBuilder);
        }
        public static UpsertUpdateStatement Update(this UpsertDoStatement stmt)
        {
            return new UpsertUpdateStatement(stmt.QueryBuilder);
        }
    }
}
