using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldZeroblobExtensions
    {
        public static ZeroblobFunction Zeroblob(this PostgreSQLDSLContext stmt, ISelectExpression x)
        {
            return new ZeroblobFunction(x);
        }
    }
}
