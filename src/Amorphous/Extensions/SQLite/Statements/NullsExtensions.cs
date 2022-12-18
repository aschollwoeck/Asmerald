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
