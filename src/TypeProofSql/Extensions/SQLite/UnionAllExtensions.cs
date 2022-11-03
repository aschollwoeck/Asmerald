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
        public static UnionAllStatement UnionAll<T>(this FromStatement<T> stmt, IQueryBuilder subQueryBuilder)
            where T : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder, new T());
        }
        public static UnionAllStatement UnionAll<T1, T2>(this NonConditionalJoinStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static UnionAllStatement UnionAll<T1, T2>(this OnStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static UnionAllStatement UnionAll<T1, T2>(this OnMultiStatement<T1, T2> stmt, IQueryBuilder subQueryBuilder)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder, new T1(), new T2());
        }
        public static UnionAllStatement UnionAll(this WhereStatement stmt, IQueryBuilder subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder);
        }
        public static UnionAllStatement UnionAll(this WhereGroupStatement stmt, IQueryBuilder subQueryBuilder)
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
