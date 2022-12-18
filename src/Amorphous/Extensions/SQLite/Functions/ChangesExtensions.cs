using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlChangesExtensions
    {
        public static ChangesFunction Changes(this SQLiteDSLContext stmt)
        {
            return new ChangesFunction();
        }
    }
}
