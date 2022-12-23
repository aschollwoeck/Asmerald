using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldIifExtensions
    {
        public static IifFunction Iif(this MariaDBDSLContext stmt, ConditionalExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new IifFunction(x, y, z);
        }
    }
}
