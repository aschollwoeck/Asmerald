using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.Functions.SQLite;
using Germanium.Statements;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlChangesExtensions
    {
        public static ChangesFunction Changes(this SQLiteDSLContext stmt)
        {
            return new ChangesFunction();
        }
    }
}
