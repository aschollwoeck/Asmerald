using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class PostgreSQLQueryBuilder : QueryBuilderBase
    {
        public PostgreSQLQueryBuilder() : base(new PostgreSQLTransformer())
        {

        }
    }
}
