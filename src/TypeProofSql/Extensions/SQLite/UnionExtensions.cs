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
        public static UnionStatement Union<T>(this FromStatement<T> stmt, IQueryBuilder subQueryBuilder)
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
        public static UnionStatement Union(this WhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this WhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionStatement Union(this HavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
