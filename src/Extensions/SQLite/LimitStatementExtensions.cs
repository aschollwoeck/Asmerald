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
        public static LimitStatement Limit(this FromStatement selectStmt, int limit)
        {
            return new LimitStatement(selectStmt.QueryBuilder, limit);
        }

        public static LimitStatement Limit(this ConditionalStatement condStmt, int limit)
        {
            return new LimitStatement(condStmt.QueryBuilder, limit);
        }

        public static LimitStatement Limit(this ConditionalGroupStatement condStmt, int limit)
        {
            return new LimitStatement(condStmt.QueryBuilder, limit);
        }

        public static LimitStatement Limit(this GroupByStatement groupByStmt, int limit)
        {
            return new LimitStatement(groupByStmt.QueryBuilder, limit);
        }

        public static LimitStatement Limit(this OrderByStatement condStmt, int limit)
        {
            return new LimitStatement(condStmt.QueryBuilder, limit);
        }
    }
}
