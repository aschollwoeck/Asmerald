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
    public static partial class TypeProofSqlCoalesceExtensions
    {
        public static CoalesceFunction Coalesce(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x, y, z);
        }
    }
}
