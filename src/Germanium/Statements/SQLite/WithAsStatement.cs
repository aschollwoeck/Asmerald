using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class WithAsStatement : AsStatement
    {
        public WithAsStatement() { }
        public WithAsStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
