using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.Join;
using TypeProofSql.Columns;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        public static WithStatement With(this IQueryBuilder queryBuilder)
        {
            return new WithStatement(queryBuilder);
        }

        public static RecursiveStatement<T> Recursive<T>(this WithStatement stmt, params ISelectColumn<T>[] selectColumns) where T : ITable, new()
        {
            return new RecursiveStatement<T>(stmt.QueryBuilder, selectColumns);
        }

        public static WithTableStatement<T> With<T>(this IQueryBuilder queryBuilder, params ISelectColumn<T>[] selectColumns) where T : ITable, new()
        {
            return new WithTableStatement<T>(queryBuilder, selectColumns);
        }

        public static AsSelectStatement As<T>(this RecursiveStatement<T> stmt, IQueryBuilderContainer queryBuilder) where T : ITable, new()
        {
            return new AsSelectStatement(stmt.QueryBuilder, queryBuilder.QueryBuilder);
        }

        public static AsSelectStatement As<T>(this WithTableStatement<T> stmt, IQueryBuilderContainer queryBuilder) where T : ITable, new()
        {
            return new AsSelectStatement(stmt.QueryBuilder, queryBuilder.QueryBuilder);
        }

        public static AsSelectStatement As<T>(this WithTableAdditionalStatement<T> stmt, IQueryBuilderContainer queryBuilder) where T : ITable, new()
        {
            return new AsSelectStatement(stmt.QueryBuilder, queryBuilder.QueryBuilder);
        }

        public static AsStatement As<T>(this RecursiveStatement<T> stmt) where T: ITable, new()
        {
            return new AsStatement(stmt.QueryBuilder);
        }

        public static AsStatement As<T>(this WithTableStatement<T> stmt) where T : ITable, new()
        {
            return new AsStatement(stmt.QueryBuilder);
        }

        public static NotStatement Not(this AsStatement stmt)
        {
            return new NotStatement(stmt.QueryBuilder);
        }

        public static NotStatement Not(this AsSelectStatement stmt)
        {
            return new NotStatement(stmt.QueryBuilder);
        }

        public static MaterializedStatement Materialized(this AsStatement stmt, IQueryBuilderContainer queryBuilder)
        {
            return new MaterializedStatement(stmt.QueryBuilder, queryBuilder.QueryBuilder);
        }

        public static MaterializedStatement Materialized(this NotStatement stmt, IQueryBuilderContainer queryBuilder)
        {
            return new MaterializedStatement(stmt.QueryBuilder, queryBuilder.QueryBuilder);
        }

        public static MaterializedStatement Materialized(this WithTableAdditionalStatement stmt, IQueryBuilderContainer queryBuilder)
        {
            return new MaterializedStatement(stmt.QueryBuilder, queryBuilder.QueryBuilder);
        }

        public static WithTableAdditionalStatement<T> With<T>(this AsSelectStatement stmt, params ISelectColumn<T>[] selectColumns) where T : ITable, new()
        {
            return new WithTableAdditionalStatement<T>(stmt.QueryBuilder, selectColumns);
        }

        public static WithTableAdditionalStatement<T> With<T>(this MaterializedStatement stmt, params ISelectColumn<T>[] selectColumns) where T : ITable, new()
        {
            return new WithTableAdditionalStatement<T>(stmt.QueryBuilder, selectColumns);
        }
    }
}
