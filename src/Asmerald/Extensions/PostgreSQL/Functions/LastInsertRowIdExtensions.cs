using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldLastInsertRowIdExtensions
    {
        public static LastInsertRowIdFunction LastInsertRowId(this PostgreSQLDSLContext stmt)
        {
            return new LastInsertRowIdFunction();
        }
    }
}
