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
    public static partial class TypeProofSqlLikelihoodExtensions
    {
        public static LikelihoodFunction Likelihood(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new LikelihoodFunction(x, y);
        }
    }
}
