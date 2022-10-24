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
        public static InsertStatement Insert(this IQueryBuilder queryBuilder)
        {
            return new InsertStatement(queryBuilder);
        }

        public static IntoStatement<T> Into<T>(this InsertStatement stmt) where T : ITable, new()
        {
            var smt = new IntoStatement<T>(stmt.QueryBuilder, new T());

            return smt;
        }

        public static ValueStatement Values<T>(this IntoStatement<T> stmt, params ValueExpression[] valueExpressions) where T : ITable, new()
        {
            var v = new ValueStatement(stmt.QueryBuilder, valueExpressions);

            return v;
        }
    }
}
