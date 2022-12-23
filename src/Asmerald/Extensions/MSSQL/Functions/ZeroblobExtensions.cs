using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this MSSQLDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
