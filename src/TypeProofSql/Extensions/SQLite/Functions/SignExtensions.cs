using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Functions.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlSignExtensions
    {
        public static SignFunction Sign(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new SignFunction(x);
        }
    }
}
