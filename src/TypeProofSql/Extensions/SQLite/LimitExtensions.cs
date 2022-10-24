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
    public static partial class TypeProofSqlLimitExtensions
    {
        public static LimitStatement Limit(this FromStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this GroupByStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this OrderByStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
        public static LimitStatement Limit(this WhereStatement stmt, int limit)
        {
            return new LimitStatement(stmt.QueryBuilder, limit);
        }
    }
}
