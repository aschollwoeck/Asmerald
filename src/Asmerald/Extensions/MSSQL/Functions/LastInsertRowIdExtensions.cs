using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldLastInsertRowIdExtensions
    {
        public static LastInsertRowIdFunction LastInsertRowId(this MSSQLDSLContext stmt)
        {
            return new LastInsertRowIdFunction();
        }
    }
}
