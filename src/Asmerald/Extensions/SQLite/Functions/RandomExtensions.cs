using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlRandomExtensions
    {
        public static RandomFunction Random(this SQLiteDSLContext stmt)
        {
            return new RandomFunction();
        }
    }
}
