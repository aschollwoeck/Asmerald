using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlOffsetExtensions
    {
        public static OffsetStatement Offset(this LimitStatement stmt, int offset)
        {
            return new OffsetStatement(stmt.QueryBuilder, offset);
        }
    }
}
