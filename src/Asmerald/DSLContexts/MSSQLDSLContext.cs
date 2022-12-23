using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;

namespace Asmerald
{
    public class MSSQLDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public MSSQLDSLContext()
        {
            this.QueryBuilder = new MSSQLQueryBuilder();
        }

        public MSSQLDSLContext SubQuery()
        {
            return new MSSQLDSLContext();
        }
    }
}
