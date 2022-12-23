using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldChangesExtensions
    {
        public static ChangesFunction Changes(this MSSQLDSLContext stmt)
        {
            return new ChangesFunction();
        }
    }
}
