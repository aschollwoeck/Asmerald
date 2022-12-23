using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MSSQL;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldWithExtensions
    {
        public static WithTableStatement<T> With<T>(this MSSQLDSLContext stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableStatement<T>(stmt.QueryBuilder, selectColumns);
        }
        public static WithStatement With(this MSSQLDSLContext stmt)
        {
            return new WithStatement(stmt.QueryBuilder);
        }
        public static WithTableAdditionalStatement<T> With<T>(this WithAsStatement stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableAdditionalStatement<T>(stmt.QueryBuilder, selectColumns);
        }
        public static WithTableStatement<T> With<T>(this WithAsSelectStatement<T> stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableStatement<T>(stmt.QueryBuilder, selectColumns);
        }
        public static WithTableAdditionalStatement<T> With<T>(this MaterializedStatement stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableAdditionalStatement<T>(stmt.QueryBuilder, selectColumns);
        }
    }
}
