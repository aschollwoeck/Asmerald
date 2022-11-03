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
            return new LimitStatement(stmt.QueryBuilder, limit, new T());
        }
        public static LimitStatement Limit<T1, T2>(this NonConditionalJoinStatement<T1, T2> stmt, int limit)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit, new T1(), new T2());
        }
        public static LimitStatement Limit<T1, T2>(this OnStatement<T1, T2> stmt, int limit)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit, new T1(), new T2());
        }
        public static LimitStatement Limit<T1, T2>(this OnMultiStatement<T1, T2> stmt, int limit)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new LimitStatement(stmt.QueryBuilder, limit, new T1(), new T2());
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
