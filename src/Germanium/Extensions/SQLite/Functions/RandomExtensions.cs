using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.Functions.SQLite;
using Germanium.Statements;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlRandomExtensions
    {
        public static RandomFunction Random(this SQLiteDSLContext stmt)
        {
            return new RandomFunction();
        }
    }
}
