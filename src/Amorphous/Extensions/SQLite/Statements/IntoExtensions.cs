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
