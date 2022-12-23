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
    public static partial class TypeProofSqlAscExtensions
    {
        public static AscStatement Asc(this OrderByStatement stmt)
        {
            return new AscStatement(stmt.QueryBuilder);
        }
        public static AscStatement Asc(this CollateStatement stmt)
        {
            return new AscStatement(stmt.QueryBuilder);
        }
    }
}
