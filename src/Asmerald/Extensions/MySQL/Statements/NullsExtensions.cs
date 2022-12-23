using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MySQL;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldNullsExtensions
    {
        public static NullsStatement Nulls(this OrderByStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
        public static NullsStatement Nulls(this CollateStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
        public static NullsStatement Nulls(this AscStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
        public static NullsStatement Nulls(this DescStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
    }
}
