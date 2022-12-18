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
