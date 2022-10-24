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
        public static UpdateStatement<T> Update<T>(this SQLiteDSLContext stmt)
            where T : ITable, new()
        {
            return new UpdateStatement<T>(stmt.QueryBuilder);
        }
    }
}
