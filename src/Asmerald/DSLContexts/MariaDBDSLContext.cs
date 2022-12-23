using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;

namespace Asmerald
{
    public class MariaDBDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public MariaDBDSLContext()
        {
            this.QueryBuilder = new MariaDBQueryBuilder();
        }

        public MariaDBDSLContext SubQuery()
        {
            return new MariaDBDSLContext();
        }
    }
}
