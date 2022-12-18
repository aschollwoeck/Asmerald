using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpdateReplaceStatement : ReplaceStatement
    {
        public ITable Table { get; private set; }
        public UpdateReplaceStatement() { }
        public UpdateReplaceStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
