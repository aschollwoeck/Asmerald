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
    public static partial class TypeProofSqlUpdateExtensions
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
