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
        public static SelectWhereStatement Where<T>(this SelectFromStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereGroupStatement Where<T>(this SelectFromStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereGroupStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereStatement Where<T, J>(this OnStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereGroupStatement Where<T, J>(this OnStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereStatement Where<T, J>(this OnMultiStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereGroupStatement Where<T, J>(this OnMultiStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
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
        public static SelectWhereStatement Where(this UpsertConflictSelectColumnsStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereGroupStatement Where(this UpsertConflictSelectColumnsStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static UpsertWhereStatement Where(this UpsertSetStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new UpsertWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static DeleteWhereStatement Where<T>(this DeleteFromStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new DeleteWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
    }
}
