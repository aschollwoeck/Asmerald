using System;
using System.Collections.Generic;
using System.Text;

namespace Germanium.Columns
{
    public abstract class OrderByColumn : IOrderByColumn
    {
        private readonly string _name = "name";

        string Name => _name;

        public OrderByColumn(string name)
        {
            _name = name;
        }

        string IColumn.Name()
        {
            return _name;
        }
    }

    public class OrderByAscColumn : OrderByColumn
    {
        public OrderByAscColumn(string name) : base(name)
        {
        }
    }

    public class OrderByDescColumn : OrderByColumn
    {
        public OrderByDescColumn(string name) : base(name)
        {
        }
    }
}
