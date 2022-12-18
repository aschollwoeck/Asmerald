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
    public static partial class TypeProofSqlNullsExtensions
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
