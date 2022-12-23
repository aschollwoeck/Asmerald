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
    public static partial class TypeProofSqlDescExtensions
    {
        public static DescStatement Desc(this OrderByStatement stmt)
        {
            return new DescStatement(stmt.QueryBuilder);
        }
        public static DescStatement Desc(this CollateStatement stmt)
        {
            return new DescStatement(stmt.QueryBuilder);
        }
    }
}
