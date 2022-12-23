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
    public static partial class TypeProofSqlNothingExtensions
    {
        public static UpsertNothingStatement Nothing(this UpsertDoStatement stmt)
        {
            return new UpsertNothingStatement(stmt.QueryBuilder);
        }
    }
}
