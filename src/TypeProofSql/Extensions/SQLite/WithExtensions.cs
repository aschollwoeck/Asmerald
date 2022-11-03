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
    public static partial class TypeProofSqlWithExtensions
    {
        public static WithTableStatement With(this SQLiteDSLContext stmt, ITable table, params ISelectColumn[] selectColumns)
        {
            return new WithTableStatement(stmt.QueryBuilder, table, selectColumns);
        }
        public static WithStatement With(this SQLiteDSLContext stmt)
        {
            return new WithStatement(stmt.QueryBuilder);
        }
        public static WithTableAdditionalStatement<T> With<T>(this WithAsStatement stmt, params ISelectColumn[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableAdditionalStatement<T>(stmt.QueryBuilder, selectColumns);
        }
        public static WithTableAdditionalStatement<T> With<T>(this MaterializedStatement stmt, params ISelectColumn[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableAdditionalStatement<T>(stmt.QueryBuilder, selectColumns);
        }
    }
}
