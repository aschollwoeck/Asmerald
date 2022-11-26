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
    public static partial class TypeProofSqlSelectExtensions
    {
        public static SelectStatement Select<T>(this WithAsSelectStatement<T> stmt)
            where T : ITable, new()
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this MaterializedStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select<T>(this WithAsSelectStatement<T> stmt, params ISelectColumn[] columns)
            where T : ITable, new()
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectColumnsStatement Select(this MaterializedStatement stmt, params ISelectColumn[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this SQLiteDSLContext stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select(this SQLiteDSLContext stmt, params ISelectColumn[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this UnionStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this UnionAllStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this IntersectStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this ExceptStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static InsertSelectStatement<T> Select<T>(this IntoStatement<T> stmt, params ISelectColumn<T>[] columns)
            where T : ITable, new()
        {
            return new InsertSelectStatement<T>(stmt.QueryBuilder, columns);
        }
        public static InsertSelectStatement<T> Select<T>(this IntoAsStatement stmt, params ISelectColumn<T>[] columns)
            where T : ITable, new()
        {
            return new InsertSelectStatement<T>(stmt.QueryBuilder, columns);
        }
    }
}
