using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.Join;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        public static OffSetStatement Offset(this LimitStatement selectStmt, int offset)
        {
            return new OffSetStatement(selectStmt.QueryBuilder, offset);
        }
    }
}
