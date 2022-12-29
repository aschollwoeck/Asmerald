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
    public static partial class AsmeraldExecExtensions
    {
        public static ExecStatement Exec(this MSSQLDSLContext stmt, IStoredProcedure sp)
        {
            return new ExecStatement(stmt.QueryBuilder, sp);
        }
    }
}
