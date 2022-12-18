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
    public static partial class TypeProofSqlAscExtensions
    {
        public static AscStatement Asc(this OrderByStatement stmt)
        {
            return new AscStatement(stmt.QueryBuilder);
        }
        public static AscStatement Asc(this CollateStatement stmt)
        {
            return new AscStatement(stmt.QueryBuilder);
        }
    }
}
