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
    public static partial class TypeProofSqlIntoExtensions
    {
        public static IntoStatement<T> Into<T>(this InsertStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this ReplaceStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this AbortStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this FailStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this IgnoreStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this RollbackStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
    }
}
