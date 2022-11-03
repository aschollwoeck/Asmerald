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
        public static ExceptStatement Except<T>(this FromStatement<T> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder, new T());
        }
        public static ExceptStatement Except<T1, T2>(this NonConditionalJoinStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static ExceptStatement Except(this OnStatement stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except<T1, T2>(this OnMultiStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static ExceptStatement Except(this WhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new ExceptStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static ExceptStatement Except(this WhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
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
