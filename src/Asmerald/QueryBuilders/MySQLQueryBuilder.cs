using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class MySQLQueryBuilder : QueryBuilderBase
    {
        public MySQLQueryBuilder() : base(new MySQLTransformer())
        {

        }
    }
}
