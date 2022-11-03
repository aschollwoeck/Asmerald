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
    public static partial class TypeProofSqlInsertExtensions
    {
        public static InsertStatement Insert(this SQLiteDSLContext stmt)
        {
            return new InsertStatement(stmt.QueryBuilder);
        }
    }
}
