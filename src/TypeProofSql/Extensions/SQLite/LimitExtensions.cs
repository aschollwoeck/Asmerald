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
    public static partial class TypeProofSqlLimitExtensions
    {
        public static LimitStatement Limit<T>(this FromStatement<T> stmt, int limit)
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
        public static LimitStatement Limit(this WhereStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this WhereGroupStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this GroupByStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this HavingStatement stmt, int limit)
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
