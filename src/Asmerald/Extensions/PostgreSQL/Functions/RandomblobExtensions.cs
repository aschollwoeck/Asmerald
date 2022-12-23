using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldRandomblobExtensions
    {
        public static RandomblobFunction Randomblob(this PostgreSQLDSLContext stmt, int n)
        {
            return new RandomblobFunction(n);
        }
    }
}
