using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this SQLiteDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
