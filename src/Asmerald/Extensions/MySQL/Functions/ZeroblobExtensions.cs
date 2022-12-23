using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this MySQLDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
