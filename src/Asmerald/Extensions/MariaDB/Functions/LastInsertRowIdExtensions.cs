using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldLastInsertRowIdExtensions
    {
        public static LastInsertRowIdFunction LastInsertRowId(this MariaDBDSLContext stmt)
        {
            return new LastInsertRowIdFunction();
        }
    }
}
