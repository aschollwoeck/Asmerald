using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;
using Germanium.Statements.SQLite;

namespace Germanium.SQLite
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
