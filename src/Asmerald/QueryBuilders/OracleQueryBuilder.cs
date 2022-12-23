using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class OracleQueryBuilder : QueryBuilderBase
    {
        public OracleQueryBuilder() : base(new OracleTransformer())
        {

        }
    }
}
