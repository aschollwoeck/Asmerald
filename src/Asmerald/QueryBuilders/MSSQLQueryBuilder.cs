using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class MSSQLQueryBuilder : QueryBuilderBase
    {
        public MSSQLQueryBuilder() : base(new MSSQLTransformer())
        {

        }
    }
}
