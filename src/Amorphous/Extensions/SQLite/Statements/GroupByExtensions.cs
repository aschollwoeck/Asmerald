using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
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
        public static GroupByStatement GroupBy(this SelectWhereMultiStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this SelectWhereGroupStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this SelectWhereGroupMultiStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
    }
}
