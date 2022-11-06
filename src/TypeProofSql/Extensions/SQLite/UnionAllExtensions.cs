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
    public static partial class TypeProofSqlUnionAllExtensions
    {
        public static UnionAllStatement UnionAll<T>(this SelectFromStatement<T> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll<T, J>(this NonConditionalJoinStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll<T, J>(this OnStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll<T, J>(this OnMultiStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectWhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectWhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this ConditionalGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this HavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
