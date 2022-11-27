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
    public static partial class TypeProofSqlLTrimExtensions
    {
        public static LTrimFunction LTrim(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new LTrimFunction(x);
        }
        public static LTrimYFunction LTrim(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new LTrimYFunction(x, y);
        }
    }
}