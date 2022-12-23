using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MariaDB;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldWhereExtensions
    {
        public static SelectWhereStatement Where<T>(this SelectFromStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereMultiStatement Where<T>(this SelectFromStatement<T> stmt, List<ConditionalStatement> conditionalStatements)
            where T : ITable, new()
        {
            return new SelectWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectWhereGroupStatement Where<T>(this SelectFromStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereGroupMultiStatement Where<T>(this SelectFromStatement<T> stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
            where T : ITable, new()
        {
            return new SelectWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectWhereStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereMultiStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, List<ConditionalStatement> conditionalStatements)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectWhereGroupStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereGroupMultiStatement Where<T, J>(this NonConditionalJoinStatement<T, J> stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectWhereStatement Where<T, J>(this OnStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereMultiStatement Where<T, J>(this OnStatement<T, J> stmt, List<ConditionalStatement> conditionalStatements)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectWhereGroupStatement Where<T, J>(this OnStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereGroupMultiStatement Where<T, J>(this OnStatement<T, J> stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectWhereStatement Where<T, J>(this OnMultiStatement<T, J> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectWhereMultiStatement Where<T, J>(this OnMultiStatement<T, J> stmt, List<ConditionalStatement> conditionalStatements)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectWhereGroupStatement Where<T, J>(this OnMultiStatement<T, J> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectWhereGroupMultiStatement Where<T, J>(this OnMultiStatement<T, J> stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new SelectWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static UpdateWhereStatement Where<T>(this UpdateSetStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new UpdateWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static UpdateWhereMultiStatement Where<T>(this UpdateSetStatement<T> stmt, List<ConditionalStatement> conditionalStatements)
            where T : ITable, new()
        {
            return new UpdateWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static UpdateWhereGroupStatement Where<T>(this UpdateSetStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new UpdateWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static UpdateWhereGroupMultiStatement Where<T>(this UpdateSetStatement<T> stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
            where T : ITable, new()
        {
            return new UpdateWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static UpsertConflictWhereStatement Where(this UpsertConflictSelectColumnsStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new UpsertConflictWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static UpsertConflictWhereMultiStatement Where(this UpsertConflictSelectColumnsStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new UpsertConflictWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static UpsertConflictWhereGroupStatement Where(this UpsertConflictSelectColumnsStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new UpsertConflictWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static UpsertConflictWhereGroupMultiStatement Where(this UpsertConflictSelectColumnsStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new UpsertConflictWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static UpsertWhereStatement Where(this UpsertSetStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new UpsertWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static UpsertWhereMultiStatement Where(this UpsertSetStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new UpsertWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static UpsertWhereGroupStatement Where(this UpsertSetStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new UpsertWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static UpsertWhereGroupMultiStatement Where(this UpsertSetStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new UpsertWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static DeleteWhereStatement Where<T>(this DeleteFromStatement<T> stmt, ConditionalExpression conditionalExpression)
            where T : ITable, new()
        {
            return new DeleteWhereStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static DeleteWhereMultiStatement Where<T>(this DeleteFromStatement<T> stmt, List<ConditionalStatement> conditionalStatements)
            where T : ITable, new()
        {
            return new DeleteWhereMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static DeleteWhereGroupStatement Where<T>(this DeleteFromStatement<T> stmt, ConditionalGroupStatement groupExpr)
            where T : ITable, new()
        {
            return new DeleteWhereGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static DeleteWhereGroupMultiStatement Where<T>(this DeleteFromStatement<T> stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
            where T : ITable, new()
        {
            return new DeleteWhereGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
    }
}
