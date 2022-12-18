using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
