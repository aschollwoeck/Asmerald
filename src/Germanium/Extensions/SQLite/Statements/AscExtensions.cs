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
