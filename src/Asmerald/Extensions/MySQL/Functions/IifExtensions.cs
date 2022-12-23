using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldIifExtensions
    {
        public static IifFunction Iif(this MySQLDSLContext stmt, ConditionalExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new IifFunction(x, y, z);
        }
    }
}
