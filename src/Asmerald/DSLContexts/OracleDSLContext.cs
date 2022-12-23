using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;

namespace Asmerald
{
    public class OracleDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public OracleDSLContext()
        {
            this.QueryBuilder = new OracleQueryBuilder();
        }

        public OracleDSLContext SubQuery()
        {
            return new OracleDSLContext();
        }
    }
}
