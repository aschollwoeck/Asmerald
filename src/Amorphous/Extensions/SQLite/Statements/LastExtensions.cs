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
    public static partial class TypeProofSqlLastExtensions
    {
        public static LastStatement Last(this NullsStatement stmt)
        {
            return new LastStatement(stmt.QueryBuilder);
        }
    }
}
