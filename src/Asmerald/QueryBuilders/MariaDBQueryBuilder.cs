using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class MariaDBQueryBuilder : QueryBuilderBase
    {
        public MariaDBQueryBuilder() : base(new MariaDBTransformer())
        {

        }
    }
}
