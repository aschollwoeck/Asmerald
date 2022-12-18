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
    public static partial class TypeProofSqlCollateExtensions
    {
        public static CollateStatement Collate(this OrderByStatement stmt)
        {
            return new CollateStatement(stmt.QueryBuilder);
        }
    }
}
