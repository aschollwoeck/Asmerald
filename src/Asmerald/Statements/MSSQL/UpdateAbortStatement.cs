using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
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
