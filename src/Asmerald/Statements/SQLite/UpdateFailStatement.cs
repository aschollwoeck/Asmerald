using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class UpdateFailStatement : FailStatement
    {
        public ITable Table { get; private set; }
        public UpdateFailStatement() { }
        public UpdateFailStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
