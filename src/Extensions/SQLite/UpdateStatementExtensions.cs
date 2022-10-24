using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.Join;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        public static UpdateStatement<T> Update<T>(this IQueryBuilder queryBuilder) where T : ITable, new()
        {
            return new UpdateStatement<T>(queryBuilder, new T());
        }

        public static SetStatement Set<T>(this UpdateStatement<T> stmt, params ValueExpression[] valueExpressions) where T : ITable, new()
        {
            var v = new SetStatement(stmt.QueryBuilder, valueExpressions);

            return v;
        }
    }
}
