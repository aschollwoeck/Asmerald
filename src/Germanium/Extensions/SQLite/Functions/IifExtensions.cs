using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.Functions.SQLite;
using Germanium.Statements;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlIifExtensions
    {
        public static IifFunction Iif(this SQLiteDSLContext stmt, ConditionalExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new IifFunction(x, y, z);
        }
    }
}
