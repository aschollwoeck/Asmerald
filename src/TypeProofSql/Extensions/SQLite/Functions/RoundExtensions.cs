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
    public static partial class TypeProofSqlRoundExtensions
    {
        public static RoundFunction Round(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new RoundFunction(x);
        }
        public static RoundDigitsFunction Round(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x, y);
        }
    }
}
