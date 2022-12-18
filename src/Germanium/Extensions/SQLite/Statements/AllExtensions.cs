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
    public static partial class TypeProofSqlAllExtensions
    {
        public static AllStatement All(this SelectStatement stmt)
        {
            return new AllStatement(stmt.QueryBuilder);
        }
        public static AllStatement All(this DistinctStatement stmt)
        {
            return new AllStatement(stmt.QueryBuilder);
        }
        public static ReturningAllStatement All(this ReturningStatement stmt)
        {
            return new ReturningAllStatement(stmt.QueryBuilder);
        }
    }
}
