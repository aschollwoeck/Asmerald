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
        public static OrderByStatement OrderBy(this FromStatement selectStmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(selectStmt.QueryBuilder, orderByColumns);
        }

        public static OrderByStatement OrderBy(this ConditionalGroupStatement condStmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(condStmt.QueryBuilder, orderByColumns);
        }

        public static OrderByStatement OrderBy(this ConditionalStatement condStmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(condStmt.QueryBuilder, orderByColumns);
        }

        public static OrderByStatement OrderBy(this GroupByStatement groupByStmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(groupByStmt.QueryBuilder, orderByColumns);
        }
    }
}
