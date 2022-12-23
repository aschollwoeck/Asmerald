using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;

namespace Asmerald
{
    public class PostgreSQLDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public PostgreSQLDSLContext()
        {
            this.QueryBuilder = new PostgreSQLQueryBuilder();
        }

        public PostgreSQLDSLContext SubQuery()
        {
            return new PostgreSQLDSLContext();
        }
    }
}
