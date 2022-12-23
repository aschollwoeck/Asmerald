using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MySQL;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldSelectExtensions
    {
        public static SelectStatement Select<T>(this WithAsSelectStatement<T> stmt)
            where T : ITable, new()
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this MaterializedStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select<T>(this WithAsSelectStatement<T> stmt, params ISelectExpression[] columns)
            where T : ITable, new()
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectColumnsStatement Select(this MaterializedStatement stmt, params ISelectExpression[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this MySQLDSLContext stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select(this MySQLDSLContext stmt, params ISelectExpression[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this UnionStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this UnionAllStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this IntersectStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this ExceptStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static InsertSelectStatement<T> Select<T>(this IntoStatement<T> stmt, params ISelectColumn<T>[] columns)
            where T : ITable, new()
        {
            return new InsertSelectStatement<T>(stmt.QueryBuilder, columns);
        }
        public static InsertSelectStatement<T> Select<T>(this IntoAsStatement stmt, params ISelectColumn<T>[] columns)
            where T : ITable, new()
        {
            return new InsertSelectStatement<T>(stmt.QueryBuilder, columns);
        }
    }
}
