using System;
using System.Collections.Generic;
using System.Text;

namespace Germanium.Columns
{
    public class CountColumn<D> : ISelectColumn<D> where D : ITable
    {
        public string Name => _origin.Name;

        private ISelectColumn _origin;

        public CountColumn(ISelectColumn origin)
        {
            this._origin = origin;
        }
    }
}
