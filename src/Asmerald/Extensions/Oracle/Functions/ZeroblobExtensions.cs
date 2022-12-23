using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this OracleDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
