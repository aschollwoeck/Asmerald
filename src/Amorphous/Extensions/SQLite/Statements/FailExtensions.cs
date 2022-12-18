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
    public static partial class TypeProofSqlFailExtensions
    {
        public static InsertFailStatement Fail(this InsertOrStatement stmt)
        {
            return new InsertFailStatement(stmt.QueryBuilder);
        }
        public static UpdateFailStatement<T> Fail<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateFailStatement<T>(stmt.QueryBuilder);
        }
    }
}
