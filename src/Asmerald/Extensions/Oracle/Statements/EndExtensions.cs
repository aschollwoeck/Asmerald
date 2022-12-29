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
    public static partial class AsmeraldEndExtensions
    {
        public static EndStatement End(this BeginSPStatement stmt)
        {
            return new EndStatement(stmt.QueryBuilder);
        }
    }
}
