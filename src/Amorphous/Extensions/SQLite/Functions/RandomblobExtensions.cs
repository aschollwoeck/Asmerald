using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this SQLiteDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
