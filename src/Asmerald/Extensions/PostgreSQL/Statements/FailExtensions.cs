using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.PostgreSQL;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldFailExtensions
    {
        public static InsertFailStatement Fail(this InsertOrStatement stmt)
        {
            return new InsertFailStatement(stmt.QueryBuilder);
        }
        public static UpdateFailStatement<T> Fail<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateFailStatement<T>(stmt.QueryBuilder);
        }
    }
}
