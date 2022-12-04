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
    public static partial class TypeProofSqlNotExtensions
    {
        public static WithNotStatement Not(this WithAsStatement stmt)
        {
            return new WithNotStatement(stmt.QueryBuilder);
        }
    }
}
