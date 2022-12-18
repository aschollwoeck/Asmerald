using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpdateAbortStatement : AbortStatement
    {
        public ITable Table { get; private set; }
        public UpdateAbortStatement() { }
        public UpdateAbortStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
