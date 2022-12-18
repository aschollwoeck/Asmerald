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
    public static partial class TypeProofSqlWithExtensions
    {
        public static WithTableStatement<T> With<T>(this SQLiteDSLContext stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new WithTableStatement<T>(stmt.QueryBuilder, selectColumns);
        }
        public static WithStatement With(this SQLiteDSLContext stmt)
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
