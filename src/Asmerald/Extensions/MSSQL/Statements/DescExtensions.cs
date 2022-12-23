using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MSSQL;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldDescExtensions
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
