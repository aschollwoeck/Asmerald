using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.PostgreSQL;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldOnExtensions
    {
        public static OnStatement<T, J> On<T, J>(this ConditionalJoinStatement<T, J> stmt, ISelectColumn<T> left, ISelectColumn<J> right)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OnStatement<T, J>(stmt.QueryBuilder, left, right);
        }
        public static OnMultiStatement<T, J> On<T, J>(this ConditionalJoinStatement<T, J> stmt, params (ISelectColumn<T> left, ISelectColumn<J> right)[] on)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OnMultiStatement<T, J>(stmt.QueryBuilder, on);
        }
        public static OnStatement<T, J> On<T, J>(this ConditionalJoinStatement stmt, ISelectColumn<T> left, ISelectColumn<J> right)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OnStatement<T, J>(stmt.QueryBuilder, left, right);
        }
        public static OnMultiStatement<T, J> On<T, J>(this ConditionalJoinStatement stmt, params (ISelectColumn<T> left, ISelectColumn<J> right)[] on)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new OnMultiStatement<T, J>(stmt.QueryBuilder, on);
        }
        public static UpsertOnStatement On<T>(this InsertSelectStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpsertOnStatement(stmt.QueryBuilder);
        }
        public static UpsertOnStatement On(this InsertValuesStatement stmt)
        {
            return new UpsertOnStatement(stmt.QueryBuilder);
        }
        public static UpsertOnStatement On(this UpsertNothingStatement stmt)
        {
            return new UpsertOnStatement(stmt.QueryBuilder);
        }
        public static UpsertOnStatement On(this UpsertSetStatement stmt)
        {
            return new UpsertOnStatement(stmt.QueryBuilder);
        }
    }
}
