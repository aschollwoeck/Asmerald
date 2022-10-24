using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.Columns
{
    public abstract class AliasColumn : IColumn
    {
        public string Alias { get; private set; }
        protected ISelectColumn _origin;

        public AliasColumn(ISelectColumn origin, string alias)
        {
            this._origin = origin;
            this.Alias = alias;
        }

        string IColumn.Name() => _origin.Name;
    }

    public class AliasColumn<D> : AliasColumn, ISelectColumnAlias<D> where D : ITable
    {
        public string Name => _origin.Name;

        public AliasColumn(ISelectColumn origin, string alias)
            : base(origin, alias)
        {
        }
    }
}
