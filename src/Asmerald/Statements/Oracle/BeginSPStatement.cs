using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class BeginSPStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public Asmerald.StoredProcedures.IStoredProcedure Sp { get; private set; }
        public BeginSPStatement() { }
        public BeginSPStatement(IQueryBuilder queryBuilder, Asmerald.StoredProcedures.IStoredProcedure sp)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Sp = sp;
        }
    }
}
