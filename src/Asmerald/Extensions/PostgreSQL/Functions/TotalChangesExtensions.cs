using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldTotalChangesExtensions
    {
        public static TotalChangesFunction TotalChanges(this PostgreSQLDSLContext stmt)
        {
            return new TotalChangesFunction();
        }
    }
}
