using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldIifExtensions
    {
        public static IifFunction Iif(this PostgreSQLDSLContext stmt, ConditionalExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new IifFunction(x, y, z);
        }
    }
}
