using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.Join;
using TypeProofSql.Columns;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        public static UnionAllStatement UnionAll(this IQueryBuilder queryBuilder, IQueryBuilderContainer subQueryBuilder)
        {
            return new UnionAllStatement(queryBuilder, subQueryBuilder.QueryBuilder);
        }

        public static UnionAllStatement UnionAll(this UnionAllStatement stmt, IQueryBuilderContainer subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder.QueryBuilder);
        }

        public static IQueryBuilderContainer UnionAll(this IQueryBuilderContainer stmt, IQueryBuilderContainer subQueryBuilder)
        {
            return new UnionAllStatement(stmt.QueryBuilder, subQueryBuilder.QueryBuilder);
        }
    }
}
