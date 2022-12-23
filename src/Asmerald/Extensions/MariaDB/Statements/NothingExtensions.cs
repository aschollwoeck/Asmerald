using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MariaDB;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldNothingExtensions
    {
        public static UpsertNothingStatement Nothing(this UpsertDoStatement stmt)
        {
            return new UpsertNothingStatement(stmt.QueryBuilder);
        }
    }
}
