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
    public static partial class TypeProofSqlUnionExtensions
    {
        public static UnionStatement Union<T>(this SelectFromStatement<T> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union<T, J>(this NonConditionalJoinStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union<T, J>(this OnStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union<T, J>(this OnMultiStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectWhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectWhereMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectWhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectWhereGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectHavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectHavingMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectHavingGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this SelectHavingGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
