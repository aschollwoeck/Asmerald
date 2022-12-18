using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amorphous.Columns;

namespace Amorphous
{
    public class Tbl_With : ITable
    {
        string ITable.Name() => "testtable";


        public static Col_Id Id() => new Col_Id();

        public static Col_Name Name() => new Col_Name();



        public class Col_Id : IntegerColumn<Tbl_With>, ISelectColumn<Tbl_With>, ISelectColumnAlias<Tbl_With>
        {
            private readonly string _name = "id";

            string ISelectColumn.Name => _name;

            public Col_Id() { }

            public override string Name() => _name;

            public override ISelectColumnAlias<Tbl_With> As(string name) => new AliasColumn<Tbl_With>(this, name);

            public override ISelectColumn<Tbl_With> Count() => new CountColumn<Tbl_With>(this);
        }

        public class Col_Name : StringColumn<Tbl_With>, ISelectColumn<Tbl_With>, ISelectColumnAlias<Tbl_With>
        {
            private readonly string _name = "name";

            string ISelectColumn.Name => _name;

            public Col_Name() { }

            public override string Name() => _name;

            public override ISelectColumnAlias<Tbl_With> As(string name) => new AliasColumn<Tbl_With>(this, name);

            public override ISelectColumn<Tbl_With> Count() => new CountColumn<Tbl_With>(this);
        }
    }
    }
