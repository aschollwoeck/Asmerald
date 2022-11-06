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
        public static GroupByStatement GroupBy<T, J>(this NonConditionalJoinStatement<T, J> stmt, params IColumn[] groupByColumns)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy<T, J>(this OnStatement<T, J> stmt, params IColumn[] groupByColumns)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy<T, J>(this OnMultiStatement<T, J> stmt, params IColumn[] groupByColumns)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this SelectWhereStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this SelectWhereGroupStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this ConditionalGroupStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
    }
}
