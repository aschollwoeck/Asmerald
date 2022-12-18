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
