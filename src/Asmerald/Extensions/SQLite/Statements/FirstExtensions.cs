using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.SQLite;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlFirstExtensions
    {
        public static FirstStatement First(this NullsStatement stmt)
        {
            return new FirstStatement(stmt.QueryBuilder);
        }
    }
}
