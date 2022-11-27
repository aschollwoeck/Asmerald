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
    public static partial class TypeProofSqlSubstringExtensions
    {
        public static SubstringLengthFunction Substring(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x, y, z);
        }
        public static SubstringFunction Substring(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new SubstringFunction(x, y);
        }
    }
}
