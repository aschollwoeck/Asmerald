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
    public static partial class TypeProofSqlInsertExtensions
    {
        public static InsertStatement Insert(this SQLiteDSLContext stmt)
        {
            return new InsertStatement(stmt.QueryBuilder);
        }
    }
}
