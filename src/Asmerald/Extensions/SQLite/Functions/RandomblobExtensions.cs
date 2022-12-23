using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this SQLiteDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
