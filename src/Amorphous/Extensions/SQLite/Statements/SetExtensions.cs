using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlSetExtensions
    {
        public static UpdateSetStatement<T> Set<T>(this UpdateStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateAbortStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateFailStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateIgnoreStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateReplaceStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpdateSetStatement<T> Set<T>(this UpdateRollbackStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new UpdateSetStatement<T>(stmt.QueryBuilder, valueExpressions);
        }
        public static UpsertSetStatement Set(this UpsertUpdateStatement stmt, params ValueExpression[] valueExpressions)
        {
            return new UpsertSetStatement(stmt.QueryBuilder, valueExpressions);
        }
    }
}
