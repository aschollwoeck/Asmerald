using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlReturningExtensions
    {
        public static ReturningStatement Returning(this UpsertNothingStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpsertSetStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpsertWhereStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpsertWhereMultiStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpsertWhereGroupStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpsertWhereGroupMultiStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning<T>(this UpdateSetStatement<T> stmt)
            where T : ITable, new()
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpdateWhereStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpdateWhereMultiStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpdateWhereGroupStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this UpdateWhereGroupMultiStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningSelectStatement Returning(this UpsertNothingStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpsertSetStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpsertWhereStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpsertWhereMultiStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpsertWhereGroupStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpsertWhereGroupMultiStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning<T>(this UpdateSetStatement<T> stmt, params ISelectColumn[] columns)
            where T : ITable, new()
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpdateWhereStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpdateWhereMultiStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpdateWhereGroupStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this UpdateWhereGroupMultiStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningStatement Returning(this DeleteWhereStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
    }
}
