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
    public static partial class AsmeraldDefaultExtensions
    {
        public static DefaultStatement Default<T>(this IntoStatement<T> stmt)
            where T : ITable, new()
        {
            return new DefaultStatement(stmt.QueryBuilder);
        }
        public static DefaultStatement Default(this IntoAsStatement stmt)
        {
            return new DefaultStatement(stmt.QueryBuilder);
        }
    }
}
