using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldChangesExtensions
    {
        public static ChangesFunction Changes(this MySQLDSLContext stmt)
        {
            return new ChangesFunction();
        }
    }
}
