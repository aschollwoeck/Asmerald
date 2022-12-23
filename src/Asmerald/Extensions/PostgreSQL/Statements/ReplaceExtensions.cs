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
    public static partial class AsmeraldReplaceExtensions
    {
        public static InsertReplaceStatement Replace(this PostgreSQLDSLContext stmt)
        {
            return new InsertReplaceStatement(stmt.QueryBuilder);
        }
        public static InsertReplaceStatement Replace(this InsertOrStatement stmt)
        {
            return new InsertReplaceStatement(stmt.QueryBuilder);
        }
        public static UpdateReplaceStatement<T> Replace<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateReplaceStatement<T>(stmt.QueryBuilder);
        }
    }
}
