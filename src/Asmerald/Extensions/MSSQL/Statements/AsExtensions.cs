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
    public static partial class AsmeraldAsExtensions
    {
        public static WithAsStatement As<T>(this RecursiveStatement<T> stmt)
            where T : ITable, new()
        {
            return new WithAsStatement(stmt.QueryBuilder);
        }
        public static WithAsStatement As<T>(this WithTableStatement<T> stmt)
            where T : ITable, new()
        {
            return new WithAsStatement(stmt.QueryBuilder);
        }
        public static IntoAsStatement As<T>(this IntoStatement<T> stmt, string alias)
            where T : ITable, new()
        {
            return new IntoAsStatement(stmt.QueryBuilder, alias);
        }
    }
}
