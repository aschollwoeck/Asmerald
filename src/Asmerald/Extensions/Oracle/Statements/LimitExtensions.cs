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
    public static partial class AsmeraldLimitExtensions
    {
        public static LimitStatement Limit<T>(this SelectFromStatement<T> stmt, int limit)
            where T : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit<T, J>(this NonConditionalJoinStatement<T, J> stmt, int limit)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit<T, J>(this OnStatement<T, J> stmt, int limit)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit<T, J>(this OnMultiStatement<T, J> stmt, int limit)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectWhereStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectWhereMultiStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectWhereGroupStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectWhereGroupMultiStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this GroupByStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectHavingStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectHavingMultiStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectHavingGroupStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this SelectHavingGroupMultiStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this OrderByStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this CollateStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this AscStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this DescStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this FirstStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this LastStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
    }
}
