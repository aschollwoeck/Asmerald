using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.Oracle;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldIntoExtensions
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
