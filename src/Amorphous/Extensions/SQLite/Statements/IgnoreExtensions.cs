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
    public static partial class TypeProofSqlIgnoreExtensions
    {
        public static InsertIgnoreStatement Ignore(this InsertOrStatement stmt)
        {
            return new InsertIgnoreStatement(stmt.QueryBuilder);
        }
        public static UpdateIgnoreStatement<T> Ignore<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateIgnoreStatement<T>(stmt.QueryBuilder);
        }
    }
}
