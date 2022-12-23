using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.SQLite;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlDeleteExtensions
    {
        public static DeleteStatement Delete(this SQLiteDSLContext stmt)
        {
            return new DeleteStatement(stmt.QueryBuilder);
        }
    }
}
