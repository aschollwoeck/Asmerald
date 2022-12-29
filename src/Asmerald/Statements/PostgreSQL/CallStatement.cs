using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class CallStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public Asmerald.StoredProcedures.IStoredProcedure Sp { get; private set; }
        public CallStatement() { }
        public CallStatement(IQueryBuilder queryBuilder, Asmerald.StoredProcedures.IStoredProcedure sp)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Sp = sp;
        }
    }
}
