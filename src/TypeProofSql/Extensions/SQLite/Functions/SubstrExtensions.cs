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
    public static partial class TypeProofSqlSubstrExtensions
    {
        public static SubstrLengthFunction Substr(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x, y, z);
        }
        public static SubstrFunction Substr(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new SubstrFunction(x, y);
        }
    }
}
