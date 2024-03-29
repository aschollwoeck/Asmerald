/*
This file was automatically generated by Asmerald.Generate library / executable.
It is not recommened to make manual changes in this file as any changes to this file will be overwritten when the next generation happens.
In case you need modifications please refer to adjusting the generation process itself.
This is possible by creating your own executable project and referencing or forking Asmerald.Generate library / executable.
*/

using System;
using Asmerald;
using Asmerald.Columns;

namespace master
{
    public partial class production
    {
        public static TblBrands brands() => new TblBrands();
        public class TblBrands : ITable{
            string ITable.Name() => "production.brands";
            public Col_Brand_id Brand_id() => new Col_Brand_id();
            public Col_Brand_name Brand_name() => new Col_Brand_name();
            public static Col_Brand_id Brand_id(string tableAlias = "") => new Col_Brand_id(tableAlias);
            public static Col_Brand_name Brand_name(string tableAlias = "") => new Col_Brand_name(tableAlias);
            public class Col_Brand_id : IntegerColumn<TblBrands>, ISelectColumn<TblBrands>, ISelectColumnAlias<TblBrands>
            {
                private readonly string _name = "brand_id";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Brand_id() { }
                public Col_Brand_id(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblBrands> As(string name) => new AliasColumn<TblBrands>(this, name);
                public override ISelectColumn<TblBrands> Count() => new CountColumn<TblBrands>(this);
            }
            public class Col_Brand_name : StringColumn<TblBrands>, ISelectColumn<TblBrands>, ISelectColumnAlias<TblBrands>
            {
                private readonly string _name = "brand_name";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Brand_name() { }
                public Col_Brand_name(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblBrands> As(string name) => new AliasColumn<TblBrands>(this, name);
                public override ISelectColumn<TblBrands> Count() => new CountColumn<TblBrands>(this);
            }
        }
    }
}
