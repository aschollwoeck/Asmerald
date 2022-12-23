using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.PostgreSQL;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldOrderByExtensions
    {
        public static OrderByStatement OrderBy<T>(this SelectFromStatement<T> stmt, params IOrderByColumn[] orderByColumns)
            where T : ITable, new()
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy<T, J>(this NonConditionalJoinStatement<T, J> stmt, params IOrderByColumn[] orderByColumns)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy<T, J>(this OnStatement<T, J> stmt, params IOrderByColumn[] orderByColumns)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy<T, J>(this OnMultiStatement<T, J> stmt, params IOrderByColumn[] orderByColumns)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectWhereStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectWhereMultiStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectWhereGroupStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectWhereGroupMultiStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this GroupByStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectHavingStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectHavingMultiStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectHavingGroupStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this SelectHavingGroupMultiStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
    }
}
