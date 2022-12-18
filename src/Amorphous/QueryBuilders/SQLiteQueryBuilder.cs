using System;
using System.Collections.Generic;
using System.Text;

namespace Amorphous.QueryBuilders
{
    public class SQLiteQueryBuilder : QueryBuilderBase
    {
        public SQLiteQueryBuilder() : base(new SqLiteTransformer())
        {

        }
    }
}
