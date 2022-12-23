using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this OracleDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
