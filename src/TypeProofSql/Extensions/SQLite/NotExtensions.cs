using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlNotExtensions
    {
        public static NotStatement Not(this AsStatement stmt)
        {
            return new NotStatement(stmt.QueryBuilder);
        }
        public static NotStatement Not(this AsSelectStatement stmt)
        {
            return new NotStatement(stmt.QueryBuilder);
        }
    }
}
