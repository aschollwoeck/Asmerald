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
