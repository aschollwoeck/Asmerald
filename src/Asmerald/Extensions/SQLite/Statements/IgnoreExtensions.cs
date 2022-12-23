using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.SQLite;

namespace Asmerald.SQLite
{
    public static partial class AsmeraldIgnoreExtensions
    {
        public static InsertIgnoreStatement Ignore(this InsertOrStatement stmt)
        {
            return new InsertIgnoreStatement(stmt.QueryBuilder);
        }
        public static UpdateIgnoreStatement<T> Ignore<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateIgnoreStatement<T>(stmt.QueryBuilder);
        }
    }
}
