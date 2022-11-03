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
    public static partial class TypeProofSqlAsExtensions
    {
        public static WithAsStatement As<T>(this RecursiveStatement<T> stmt)
            where T : ITable, new()
        {
            return new WithAsStatement(stmt.QueryBuilder);
        }
        public static WithAsStatement As<T>(this WithTableStatement<T> stmt)
            where T : ITable, new()
        {
            return new WithAsStatement(stmt.QueryBuilder);
        }
        public static IntoAsStatement As<T>(this IntoStatement<T> stmt, string alias)
            where T : ITable, new()
        {
            return new IntoAsStatement(stmt.QueryBuilder, alias);
        }
    }
}
