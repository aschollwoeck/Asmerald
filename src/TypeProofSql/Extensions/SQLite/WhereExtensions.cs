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
    public static partial class TypeProofSqlWhereExtensions
    {
        public static WhereStatement Where<T>(this FromStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static WhereGroupStatement Where<T>(this FromStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new WhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static WhereStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static WhereGroupStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new WhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static WhereStatement Where<T, J>(this OnStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static WhereGroupStatement Where<T, J>(this OnStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new WhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static WhereStatement Where<T, J>(this OnMultiStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static WhereGroupStatement Where<T, J>(this OnMultiStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new WhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static WhereStatement Where<T>(this UpdateSetStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static WhereGroupStatement Where<T>(this UpdateSetStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new WhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static WhereStatement Where<T>(this UpdateFromStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static WhereGroupStatement Where<T>(this UpdateFromStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new WhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static UpsertWhereStatement Where(this UpsertSetStatement stmt)
        {
            return new UpsertWhereStatement(stmt.QueryBuilder);
        }
        public static DeleteWhereStatement Where<T>(this DeleteFromStatement<T> stmt)
            where T : ITable, new()
        {
            return new DeleteWhereStatement(stmt.QueryBuilder);
        }
    }
}
