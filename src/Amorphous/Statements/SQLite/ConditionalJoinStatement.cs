using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class ConditionalJoinStatement : JoinStatement
    {
        public ITable T { get; private set; }
        public ITable J { get; private set; }
        public ConditionalJoinStatement() { }
        public ConditionalJoinStatement(IQueryBuilder queryBuilder, ITable t, ITable j)
            : base(queryBuilder, t, j)
        {
            this.T = t;
            this.J = j;
        }
    }
}
