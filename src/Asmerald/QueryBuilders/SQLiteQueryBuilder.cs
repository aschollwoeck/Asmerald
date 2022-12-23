using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class SQLiteQueryBuilder : QueryBuilderBase
    {
        public SQLiteQueryBuilder() : base(new SqLiteTransformer())
        {

        }
    }
}
