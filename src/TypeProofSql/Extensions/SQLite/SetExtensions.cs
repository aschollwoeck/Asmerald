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
    public static partial class TypeProofSqlSetExtensions
    {
        public static UpdateSetStatement<T> Set<T>(this UpdateStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateAbort<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateFail<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateIgnore<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateReplace<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateRollback<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpsertSetStatement Set(this UpsertUpdateStatement stmt)
        {
            return new UpsertSetStatement(stmt.QueryBuilder);
        }
    }
}
