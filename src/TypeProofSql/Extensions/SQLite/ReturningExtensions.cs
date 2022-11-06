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
        public static ReturningStatement Returning(this SelectWhereStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this SelectWhereGroupStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning<T>(this UpdateSetStatement<T> stmt)
            where T : ITable, new()
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this WhereStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
        public static ReturningStatement Returning(this WhereGroupStatement stmt)
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
        public static ReturningSelectStatement Returning(this SelectWhereStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this SelectWhereGroupStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning<T>(this UpdateSetStatement<T> stmt, params ISelectColumn[] columns)
            where T : ITable, new()
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this WhereStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningSelectStatement Returning(this WhereGroupStatement stmt, params ISelectColumn[] columns)
        {
            return new ReturningSelectStatement(stmt.QueryBuilder, columns);
        }
        public static ReturningStatement Returning(this DeleteWhereStatement stmt)
        {
            return new ReturningStatement(stmt.QueryBuilder);
        }
    }
}
