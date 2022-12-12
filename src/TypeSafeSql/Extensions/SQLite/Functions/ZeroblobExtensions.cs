using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
