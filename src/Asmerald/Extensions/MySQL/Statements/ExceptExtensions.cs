using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MySQL;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldExceptExtensions
    {
        public static ExceptStatement Except<T>(this SelectFromStatement<T> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except<T, J>(this NonConditionalJoinStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except<T, J>(this OnStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except<T, J>(this OnMultiStatement<T, J> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectWhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectWhereMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectWhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectWhereGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectHavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectHavingMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectHavingGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this SelectHavingGroupMultiStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
