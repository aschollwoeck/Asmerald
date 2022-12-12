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
    public static partial class TypeProofSqlAscExtensions
    {
        public static AscStatement Asc(this OrderByStatement stmt)
        {
            return new AscStatement(stmt.QueryBuilder);
        }
        public static AscStatement Asc(this CollateStatement stmt)
        {
            return new AscStatement(stmt.QueryBuilder);
        }
    }
}
