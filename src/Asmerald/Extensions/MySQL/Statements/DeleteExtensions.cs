using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MySQL;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldDeleteExtensions
    {
        public static DeleteStatement Delete(this MySQLDSLContext stmt)
        {
            return new DeleteStatement(stmt.QueryBuilder);
        }
    }
}
