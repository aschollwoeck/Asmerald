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
    public static partial class AsmeraldNotExtensions
    {
        public static WithNotStatement Not(this WithAsStatement stmt)
        {
            return new WithNotStatement(stmt.QueryBuilder);
        }
    }
}
