using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Germanium.Columns;

namespace Germanium.Test
{
    public class Table1 : ITable
    {
        string ITable.Name() => "Table1";


        public class Column1 : StringColumn<Table1>, ISelectColumn<Table1>, ISelectColumnAlias<Table1>
        {
            private readonly string _name = "name";

            string ISelectColumn.Name => _name;

            public Column1() { }

            public override string Name() => _name;

            public override ISelectColumnAlias<Table1> As(string name) => new AliasColumn<Table1>(this, name);

            public override ISelectColumn<Table1> Count() => new CountColumn<Table1>(this);
        }

        public class Column2 : IntegerColumn<Table1>, ISelectColumn<Table1>, ISelectColumnAlias<Table1>
        {
            private readonly string _name = "name2";

            string ISelectColumn.Name => _name;

            public Column2() { }

            public override string Name() => _name;

            public override ISelectColumnAlias<Table1> As(string name) => new AliasColumn<Table1>(this, name);

            public override ISelectColumn<Table1> Count() => new CountColumn<Table1>(this);
        }
    }

    public class Table2 : ITable
    {
        string ITable.Name() => "Table2";


        public class Column1 : StringColumn<Table2>, ISelectColumn<Table2>, ISelectColumnAlias<Table2>
        {
            private readonly string _name = "name";

            string ISelectColumn.Name => _name;

            public Column1()
            {

            }

            public override string Name()
            {
                return _name;
            }

            public override ISelectColumnAlias<Table2> As(string name) => new AliasColumn<Table2>(this, name);

            public override ISelectColumn<Table2> Count() => new CountColumn<Table2>(this);
        }

        public class Column2 : IntegerColumn<Table2>, ISelectColumn<Table2>, ISelectColumnAlias<Table2>
        {
            private readonly string _name = "name2";

            string ISelectColumn.Name => _name;

            public Column2()
            {

            }

            public override string Name()
            {
                return _name;
            }

            public override ISelectColumnAlias<Table2> As(string name) => new AliasColumn<Table2>(this, name);

            public override ISelectColumn<Table2> Count() => new CountColumn<Table2>(this);
        }
    }
}
