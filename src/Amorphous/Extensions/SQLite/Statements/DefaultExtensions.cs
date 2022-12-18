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
