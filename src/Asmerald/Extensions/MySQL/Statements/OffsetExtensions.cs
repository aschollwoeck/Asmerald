using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MySQL;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldOffsetExtensions
    {
        public static OffsetStatement Offset(this LimitStatement stmt, int offset)
        {
            return new OffsetStatement(stmt.QueryBuilder, offset);
        }
    }
}
