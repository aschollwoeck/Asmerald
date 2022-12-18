using System;
using System.Collections.Generic;
using System.Text;

namespace Amorphous.Columns
{
    public interface ISelectColumn : ISelectExpression
    {
        string Name { get; }
    }

    //public interface ISelectColumn<T> : IColumn where T : ISelectColumn
    //{
    //    T As(string name);
    //    T Count();
    //}


    public interface ISelectColumnAlias<T> : ISelectColumn<T> where T : ITable
    {
        //ISelectColumn<T> As(string name);
    }

    public interface ISelectColumn<T> : ISelectColumn where T : ITable
    {
    }
}
