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
    public static partial class TypeProofSqlDefaultExtensions
    {
        public static DefaultStatement Default<T>(this IntoStatement<T> stmt)
            where T : ITable, new()
        {
            return new DefaultStatement(stmt.QueryBuilder);
        }
        public static DefaultStatement Default(this IntoAsStatement stmt)
        {
            return new DefaultStatement(stmt.QueryBuilder);
        }
    }
}
