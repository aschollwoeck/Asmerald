using System;
using Amorphous;
using Amorphous.Columns;

namespace test.testna
{
    public class TblPacks : ITable{
        string ITable.Name() => "packs";
        public static Col_Id Id() => new Col_Id();
        public static Col_Id Id(string tableAlias) => new Col_Id(tableAlias);
        public static Col_Name Name() => new Col_Name();
        public static Col_Name Name(string tableAlias) => new Col_Name(tableAlias);
        public static Col_Code Code() => new Col_Code();
        public static Col_Code Code(string tableAlias) => new Col_Code(tableAlias);
        public static Col_Release_date Release_date() => new Col_Release_date();
        public static Col_Release_date Release_date(string tableAlias) => new Col_Release_date(tableAlias);
        public static Col_Series Series() => new Col_Series();
        public static Col_Series Series(string tableAlias) => new Col_Series(tableAlias);
        public static Col_Type Type() => new Col_Type();
        public static Col_Type Type(string tableAlias) => new Col_Type(tableAlias);
        public class Col_Id : IntegerColumn<TblPacks>, ISelectColumn<TblPacks>, ISelectColumnAlias<TblPacks>
        {
            private readonly string _name = "id";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Id() { }
            public Col_Id(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblPacks> As(string name) => new AliasColumn<TblPacks>(this, name);
            public override ISelectColumn<TblPacks> Count() => new CountColumn<TblPacks>(this);
        }
        public class Col_Name : StringColumn<TblPacks>, ISelectColumn<TblPacks>, ISelectColumnAlias<TblPacks>
        {
            private readonly string _name = "name";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Name() { }
            public Col_Name(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblPacks> As(string name) => new AliasColumn<TblPacks>(this, name);
            public override ISelectColumn<TblPacks> Count() => new CountColumn<TblPacks>(this);
        }
        public class Col_Code : StringColumn<TblPacks>, ISelectColumn<TblPacks>, ISelectColumnAlias<TblPacks>
        {
            private readonly string _name = "code";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Code() { }
            public Col_Code(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblPacks> As(string name) => new AliasColumn<TblPacks>(this, name);
            public override ISelectColumn<TblPacks> Count() => new CountColumn<TblPacks>(this);
        }
        public class Col_Release_date : StringColumn<TblPacks>, ISelectColumn<TblPacks>, ISelectColumnAlias<TblPacks>
        {
            private readonly string _name = "release_date";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Release_date() { }
            public Col_Release_date(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblPacks> As(string name) => new AliasColumn<TblPacks>(this, name);
            public override ISelectColumn<TblPacks> Count() => new CountColumn<TblPacks>(this);
        }
        public class Col_Series : StringColumn<TblPacks>, ISelectColumn<TblPacks>, ISelectColumnAlias<TblPacks>
        {
            private readonly string _name = "series";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Series() { }
            public Col_Series(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblPacks> As(string name) => new AliasColumn<TblPacks>(this, name);
            public override ISelectColumn<TblPacks> Count() => new CountColumn<TblPacks>(this);
        }
        public class Col_Type : StringColumn<TblPacks>, ISelectColumn<TblPacks>, ISelectColumnAlias<TblPacks>
        {
            private readonly string _name = "type";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Type() { }
            public Col_Type(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblPacks> As(string name) => new AliasColumn<TblPacks>(this, name);
            public override ISelectColumn<TblPacks> Count() => new CountColumn<TblPacks>(this);
        }
    }
}
