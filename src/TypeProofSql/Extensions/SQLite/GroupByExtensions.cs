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
    public static partial class TypeProofSqlGroupByExtensions
    {
        public static GroupByStatement GroupBy(this FromStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this ConditionalGroupStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
    }
}
