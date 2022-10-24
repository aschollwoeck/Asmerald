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
        public static InnerJoinStatement<T1, T2> InnerJoin<T1, T2>(this FromStatement<T1> stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new InnerJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static InnerJoinStatement<T1, T2> InnerJoin<T1, T2>(this NonConditionalJoinStatement stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new InnerJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static LeftOuterJoinStatement<T1, T2> LeftJoin<T1, T2>(this FromStatement<T1> stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new LeftOuterJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static LeftOuterJoinStatement<T1, T2> LeftJoin<T1, T2>(this NonConditionalJoinStatement stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new LeftOuterJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static RightOuterJoinStatement<T1, T2> RightJoin<T1, T2>(this FromStatement<T1> stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new RightOuterJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static RightOuterJoinStatement<T1, T2> RightJoin<T1, T2>(this NonConditionalJoinStatement stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new RightOuterJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static FullOuterJoinStatement<T1, T2> FullJoin<T1, T2>(this FromStatement<T1> stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new FullOuterJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static FullOuterJoinStatement<T1, T2> FullJoin<T1, T2>(this NonConditionalJoinStatement stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new FullOuterJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static CrossJoinStatement<T1, T2> CrossJoin<T1, T2>(this FromStatement<T1> stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new CrossJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static CrossJoinStatement<T1, T2> CrossJoin<T1, T2>(this NonConditionalJoinStatement stmt) where T1 : ITable, new() where T2 : ITable, new()
        {
            var joinStmt = new CrossJoinStatement<T1, T2>(stmt.QueryBuilder);

            return joinStmt;
        }

        public static OnStatement<T1, T2> On<T1, T2>(this ConditionalJoinStatement<T1, T2> stmt, ISelectColumn<T1> left, ISelectColumn<T2> right) where T1 : ITable, new() where T2 : ITable, new()
        {
            var onStmt = new OnStatement<T1, T2>(stmt.QueryBuilder, left, right);

            return onStmt;
        }

        public static OnStatement<T1, T2> On<T1, T2>(this OnStatement<T1, T2> stmt, ISelectColumn<T1> left, ISelectColumn<T2> right) where T1 : ITable, new() where T2 : ITable, new()
        {
            var onStmt = new OnStatement<T1, T2>(stmt.QueryBuilder, left, right);

            return onStmt;
        }
    }
}
