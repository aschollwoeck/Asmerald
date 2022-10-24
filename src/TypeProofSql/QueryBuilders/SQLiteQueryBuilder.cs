using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.QueryBuilders
{
    public class SQLiteQueryBuilder : QueryBuilderBase
    {
        public SQLiteQueryBuilder() : base(new SqLiteTransformer())
        {

        }
    }
}
