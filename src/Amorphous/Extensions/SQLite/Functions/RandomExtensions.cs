using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlRandomExtensions
    {
        public static RandomFunction Random(this SQLiteDSLContext stmt)
        {
            return new RandomFunction();
        }
    }
}
