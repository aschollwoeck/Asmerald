using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
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
