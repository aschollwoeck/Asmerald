using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this MySQLDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
