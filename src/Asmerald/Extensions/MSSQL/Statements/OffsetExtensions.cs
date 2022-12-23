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
    public static partial class AsmeraldOffsetExtensions
    {
        public static OffsetStatement Offset(this LimitStatement stmt, int offset)
        {
            return new OffsetStatement(stmt.QueryBuilder, offset);
        }
    }
}
