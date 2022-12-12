using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class ConditionalStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }

        public ConditionalStatement(ConditionalExpression conditionalExpression)
        {
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
