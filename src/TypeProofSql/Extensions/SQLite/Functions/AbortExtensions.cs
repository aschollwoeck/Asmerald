using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;
using TypeProofSql.Functions.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlAbsExtensions
    {
        public static AbsFunctionExpression Abs(this SQLiteDSLContext ctxt, IExpression expression)
        {
            return new AbsFunctionExpression(expression);
        }
    }
}
