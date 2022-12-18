using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;

namespace Amorphous
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
