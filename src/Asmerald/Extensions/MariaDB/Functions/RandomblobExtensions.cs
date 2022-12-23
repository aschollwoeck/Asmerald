using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this MariaDBDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
