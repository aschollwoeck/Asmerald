using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;
using Germanium.Statements.SQLite;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlIntoExtensions
    {
        public static IntoStatement<T> Into<T>(this InsertStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this InsertReplaceStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this InsertAbortStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this InsertFailStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this InsertIgnoreStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
        public static IntoStatement<T> Into<T>(this InsertRollbackStatement stmt)
            where T : ITable, new()
        {
            return new IntoStatement<T>(stmt.QueryBuilder);
        }
    }
}
