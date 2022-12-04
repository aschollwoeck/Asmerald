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
    public static partial class TypeProofSqlOrderByExtensions
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
