using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldChangesExtensions
    {
        public static ChangesFunction Changes(this OracleDSLContext stmt)
        {
            return new ChangesFunction();
        }
    }
}
