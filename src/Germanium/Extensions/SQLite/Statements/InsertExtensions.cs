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
    public static partial class TypeProofSqlInsertExtensions
    {
        public static InsertStatement Insert(this SQLiteDSLContext stmt)
        {
            return new InsertStatement(stmt.QueryBuilder);
        }
    }
}
