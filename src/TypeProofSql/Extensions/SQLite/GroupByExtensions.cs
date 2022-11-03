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
        public static GroupByStatement GroupBy<T1, T2>(this NonConditionalJoinStatement<T1, T2> stmt, params IColumn[] groupByColumns)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns, new T1(), new T2());
        }
        public static GroupByStatement GroupBy<T1, T2>(this OnStatement<T1, T2> stmt, params IColumn[] groupByColumns)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns, new T1(), new T2());
        }
        public static GroupByStatement GroupBy<T1, T2>(this OnMultiStatement<T1, T2> stmt, params IColumn[] groupByColumns)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns, new T1(), new T2());
        }
        public static GroupByStatement GroupBy(this WhereStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
        public static GroupByStatement GroupBy(this WhereGroupStatement stmt, params IColumn[] groupByColumns)
        {
            return new GroupByStatement(stmt.QueryBuilder, groupByColumns);
        }
    }
}
