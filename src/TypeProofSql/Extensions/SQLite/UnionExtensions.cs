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
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder, new T());
        }
        public static UnionStatement Union<T1, T2>(this NonConditionalJoinStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static UnionStatement Union<T1, T2>(this OnStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static UnionStatement Union<T1, T2>(this OnMultiStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new UnionStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
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
