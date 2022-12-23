using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldIifExtensions
    {
        public static IifFunction Iif(this OracleDSLContext stmt, ConditionalExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new IifFunction(x, y, z);
        }
    }
}
