using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlCrossJoinExtensions
    {
        public static CrossJoinStatement<T, J> CrossJoin<T, J>(this SelectFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new CrossJoinStatement<T, J>(stmt.QueryBuilder);
        }
    }
}
