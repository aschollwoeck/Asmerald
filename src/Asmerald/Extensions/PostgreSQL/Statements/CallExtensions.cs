using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.PostgreSQL;
using Asmerald.StoredProcedures;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldCallExtensions
    {
        public static CallStatement Call(this PostgreSQLDSLContext stmt, IStoredProcedure sp)
        {
            return new CallStatement(stmt.QueryBuilder, sp);
        }
    }
}
