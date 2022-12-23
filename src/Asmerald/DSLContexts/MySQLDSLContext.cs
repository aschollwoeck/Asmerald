using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;

namespace Asmerald
{
    public class MySQLDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public MySQLDSLContext()
        {
            this.QueryBuilder = new MySQLQueryBuilder();
        }

        public MySQLDSLContext SubQuery()
        {
            return new MySQLDSLContext();
        }
    }
}
