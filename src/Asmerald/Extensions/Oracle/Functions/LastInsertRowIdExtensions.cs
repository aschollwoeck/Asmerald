using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldLastInsertRowIdExtensions
    {
        public static LastInsertRowIdFunction LastInsertRowId(this OracleDSLContext stmt)
        {
            return new LastInsertRowIdFunction();
        }
    }
}
