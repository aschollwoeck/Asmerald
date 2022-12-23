using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;

namespace Asmerald
{
    public class SQLiteDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public SQLiteDSLContext()
        {
            this.QueryBuilder = new SQLiteQueryBuilder();
        }

        public SQLiteDSLContext SubQuery()
        {
            return new SQLiteDSLContext();
        }
    }
}
