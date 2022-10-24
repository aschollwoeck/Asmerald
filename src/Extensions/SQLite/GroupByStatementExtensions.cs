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
        public static GroupByStatement GroupBy(this FromStatement selectStmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(selectStmt.QueryBuilder, groupByColumns);
        }

        public static GroupByStatement GroupBy(this ConditionalStatement condStmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(condStmt.QueryBuilder, groupByColumns);
        }

        public static GroupByStatement GroupBy(this ConditionalGroupStatement condStmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(condStmt.QueryBuilder, groupByColumns);
        }
    }
}
