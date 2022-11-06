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
    public static partial class TypeProofSqlExceptExtensions
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
        public static ExceptStatement Except(this SelectWhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this ConditionalGroupStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this GroupByStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this HavingStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
    }
}
