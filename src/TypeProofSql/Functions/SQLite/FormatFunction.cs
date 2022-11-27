using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class FormatFunction : IFunction
    {
        public string Format { get; private set; }
        public List<ISelectExpression> Z { get; private set; } = new List<ISelectExpression>();
        public FormatFunction() { }
        public FormatFunction(string format, IEnumerable<ISelectExpression> z)
        {
            this.Format = format;
            this.Z.AddRange(z);
        }
    }
}
