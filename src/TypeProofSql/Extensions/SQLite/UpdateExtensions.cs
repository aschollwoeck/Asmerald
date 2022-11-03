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
    public static partial class TypeProofSqlUpdateExtensions
    {
        public static UpdateStatement Update(this SQLiteDSLContext stmt, ITable table)
        {
            return new UpdateStatement(stmt.QueryBuilder, table);
        }
        public static UpsertUpdateStatement Update(this UpsertDoStatement stmt)
        {
            return new UpsertUpdateStatement(stmt.QueryBuilder);
        }
    }
}
