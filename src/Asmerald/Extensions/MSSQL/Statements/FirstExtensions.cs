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
    public static partial class AsmeraldFirstExtensions
    {
        public static FirstStatement First(this NullsStatement stmt)
        {
            return new FirstStatement(stmt.QueryBuilder);
        }
    }
}
