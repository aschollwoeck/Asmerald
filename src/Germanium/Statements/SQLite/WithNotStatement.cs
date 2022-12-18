using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class WithNotStatement : NotStatement
    {
        public WithNotStatement() { }
        public WithNotStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
