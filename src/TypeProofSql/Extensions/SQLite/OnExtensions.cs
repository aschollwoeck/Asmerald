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
    public static partial class TypeProofSqlOnExtensions
    {
        public static OnStatement<T1, T2> On<T1, T2>(this JoinStatement stmt, ISelectColumn<T1> left, ISelectColumn<T2> right)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new OnStatement<T1, T2>(stmt.QueryBuilder, left, right);
        }
        public static OnMultiStatement<T1, T2> On<T1, T2>(this JoinStatement stmt, (ISelectColumn<T1> left, ISelectColumn<T2> right) on)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new OnMultiStatement<T1, T2>(stmt.QueryBuilder, on);
        }
        public static OnStatement<T1, T2> On<T1, T2>(this JoinAsStatement stmt, ISelectColumn<T1> left, ISelectColumn<T2> right)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new OnStatement<T1, T2>(stmt.QueryBuilder, left, right);
        }
        public static OnMultiStatement<T1, T2> On<T1, T2>(this JoinAsStatement stmt, (ISelectColumn<T1> left, ISelectColumn<T2> right) on)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new OnMultiStatement<T1, T2>(stmt.QueryBuilder, on);
        }
        public static OnStatement<T1, T2> On<T1, T2>(this ConditionalJoinStatement stmt, ISelectColumn<T1> left, ISelectColumn<T2> right)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new OnStatement<T1, T2>(stmt.QueryBuilder, left, right);
        }
        public static OnMultiStatement<T1, T2> On<T1, T2>(this ConditionalJoinStatement stmt, (ISelectColumn<T1> left, ISelectColumn<T2> right) on)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new OnMultiStatement<T1, T2>(stmt.QueryBuilder, on);
        }
    }
}
