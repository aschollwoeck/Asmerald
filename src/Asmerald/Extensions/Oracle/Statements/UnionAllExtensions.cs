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
    public static partial class AsmeraldUnionAllExtensions
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
        public static UnionAllStatement UnionAll(this SelectWhereMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectWhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectWhereGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectHavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectHavingMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectHavingGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this SelectHavingGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
