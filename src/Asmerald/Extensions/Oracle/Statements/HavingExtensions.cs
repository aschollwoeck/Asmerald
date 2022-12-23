using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.Oracle;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldHavingExtensions
    {
        public static SelectHavingStatement Having(this GroupByStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new SelectHavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectHavingMultiStatement Having(this GroupByStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new SelectHavingMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectHavingGroupStatement Having(this GroupByStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new SelectHavingGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectHavingGroupMultiStatement Having(this GroupByStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new SelectHavingGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectHavingStatement Having(this SelectWhereStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new SelectHavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectHavingMultiStatement Having(this SelectWhereStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new SelectHavingMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectHavingGroupStatement Having(this SelectWhereStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new SelectHavingGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectHavingGroupMultiStatement Having(this SelectWhereStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new SelectHavingGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectHavingStatement Having(this SelectWhereMultiStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new SelectHavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectHavingMultiStatement Having(this SelectWhereMultiStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new SelectHavingMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectHavingGroupStatement Having(this SelectWhereMultiStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new SelectHavingGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectHavingGroupMultiStatement Having(this SelectWhereMultiStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new SelectHavingGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectHavingStatement Having(this SelectWhereGroupStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new SelectHavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectHavingMultiStatement Having(this SelectWhereGroupStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new SelectHavingMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectHavingGroupStatement Having(this SelectWhereGroupStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new SelectHavingGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectHavingGroupMultiStatement Having(this SelectWhereGroupStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new SelectHavingGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
        public static SelectHavingStatement Having(this SelectWhereGroupMultiStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new SelectHavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static SelectHavingMultiStatement Having(this SelectWhereGroupMultiStatement stmt, List<ConditionalStatement> conditionalStatements)
        {
            return new SelectHavingMultiStatement(stmt.QueryBuilder, conditionalStatements);
        }
        public static SelectHavingGroupStatement Having(this SelectWhereGroupMultiStatement stmt, ConditionalGroupStatement groupExpr)
        {
            return new SelectHavingGroupStatement(stmt.QueryBuilder, groupExpr);
        }
        public static SelectHavingGroupMultiStatement Having(this SelectWhereGroupMultiStatement stmt, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            return new SelectHavingGroupMultiStatement(stmt.QueryBuilder, conditionalGroupStatements);
        }
    }
}
