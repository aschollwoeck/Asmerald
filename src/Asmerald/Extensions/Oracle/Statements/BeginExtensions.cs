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
    public static partial class AsmeraldBeginExtensions
    {
        public static BeginSPStatement Begin(this OracleDSLContext stmt, IStoredProcedure sp)
        {
            return new BeginSPStatement(stmt.QueryBuilder, sp);
        }
    }
}
