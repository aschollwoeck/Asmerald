using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlLastInsertRowIdExtensions
    {
        public static LastInsertRowIdFunction LastInsertRowId(this SQLiteDSLContext stmt)
        {
            return new LastInsertRowIdFunction();
        }
    }
}
