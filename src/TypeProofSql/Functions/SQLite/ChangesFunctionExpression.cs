using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class ChangesFunctionExpression : ISelectExpression
    {
        public ChangesFunctionExpression() { }

        public object ValueName()
        {
            throw new NotImplementedException();
        }
    }
}
