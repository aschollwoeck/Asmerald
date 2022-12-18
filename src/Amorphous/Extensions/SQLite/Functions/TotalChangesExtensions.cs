using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlTotalChangesExtensions
    {
        public static TotalChangesFunction TotalChanges(this SQLiteDSLContext stmt)
        {
            return new TotalChangesFunction();
        }
    }
}
