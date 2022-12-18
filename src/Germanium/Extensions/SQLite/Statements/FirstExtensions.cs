using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;
using Germanium.Statements.SQLite;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlFirstExtensions
    {
        public static FirstStatement First(this NullsStatement stmt)
        {
            return new FirstStatement(stmt.QueryBuilder);
        }
    }
}
