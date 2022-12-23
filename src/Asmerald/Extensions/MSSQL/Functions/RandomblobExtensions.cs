using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this MSSQLDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
