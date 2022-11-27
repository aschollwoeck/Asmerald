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
    public static partial class TypeProofSqlCharExtensions
    {
        public static CharFunction Char(this SQLiteDSLContext stmt, ISelectExpression x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFunction(x1, x2, xn);
        }
    }
}
