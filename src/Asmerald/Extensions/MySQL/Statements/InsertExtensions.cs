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
    public static partial class AsmeraldInsertExtensions
    {
        public static InsertStatement Insert(this MySQLDSLContext stmt)
        {
            return new InsertStatement(stmt.QueryBuilder);
        }
    }
}
