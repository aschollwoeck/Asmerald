using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlIntersectExtensions
    {
        public static IntersectStatement Intersect<T>(this SelectFromStatement<T> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect<T, J>(this NonConditionalJoinStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect<T, J>(this OnStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect<T, J>(this OnMultiStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectWhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectWhereMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectWhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectWhereGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectHavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectHavingMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectHavingGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static IntersectStatement Intersect(this SelectHavingGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new IntersectStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
