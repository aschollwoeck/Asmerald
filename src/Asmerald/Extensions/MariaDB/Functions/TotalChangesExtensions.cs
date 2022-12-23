using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldTotalChangesExtensions
    {
        public static TotalChangesFunction TotalChanges(this MariaDBDSLContext stmt)
        {
            return new TotalChangesFunction();
        }
    }
}
