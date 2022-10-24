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
        public static FromStatement<T> From<T>(this SelectStatement stmt) where T : ITable, new()
        {
            var fromStmt = new FromStatement<T>(stmt.QueryBuilder, new T());

            return fromStmt;
        }

        public static FromStatement<T> From<T>(this SelectColumnsStatement stmt) where T : ITable, new()
        {
            var fromStmt = new FromStatement<T>(stmt.QueryBuilder, new T());

            return fromStmt;
        }

        public static FromStatement<T> From<T>(this DistinctColumnsStatement stmt) where T : ITable, new()
        {
            var fromStmt = new FromStatement<T>(stmt.QueryBuilder, new T());

            return fromStmt;
        }

        public static FromStatement<T> From<T>(this AllStatement stmt) where T : ITable, new()
        {
            var fromStmt = new FromStatement<T>(stmt.QueryBuilder, new T());

            return fromStmt;
        }

        public static FromStatement<T> From<T>(this DeleteStatement stmt) where T : ITable, new()
        {
            var fromStmt = new FromStatement<T>(stmt.QueryBuilder, new T());

            return fromStmt;
        }
    }
}
