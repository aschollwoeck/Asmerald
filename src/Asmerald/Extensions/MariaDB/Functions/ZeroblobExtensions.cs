using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this MariaDBDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
