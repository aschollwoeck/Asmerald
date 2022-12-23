using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldTotalChangesExtensions
    {
        public static TotalChangesFunction TotalChanges(this MSSQLDSLContext stmt)
        {
            return new TotalChangesFunction();
        }
    }
}
