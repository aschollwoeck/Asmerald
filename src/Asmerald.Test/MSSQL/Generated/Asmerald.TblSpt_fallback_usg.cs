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
    public partial class dbo
    {
        public static TblSpt_fallback_usg spt_fallback_usg() => new TblSpt_fallback_usg();
        public class TblSpt_fallback_usg : ITable{
            string ITable.Name() => "dbo.spt_fallback_usg";
            public Col_Xserver_name Xserver_name() => new Col_Xserver_name();
            public Col_Xdttm_ins Xdttm_ins() => new Col_Xdttm_ins();
            public Col_Xdttm_last_ins_upd Xdttm_last_ins_upd() => new Col_Xdttm_last_ins_upd();
            public Col_Xfallback_vstart Xfallback_vstart() => new Col_Xfallback_vstart();
            public Col_Dbid Dbid() => new Col_Dbid();
            public Col_Segmap Segmap() => new Col_Segmap();
            public Col_Lstart Lstart() => new Col_Lstart();
            public Col_Sizepg Sizepg() => new Col_Sizepg();
            public Col_Vstart Vstart() => new Col_Vstart();
            public static Col_Xserver_name Xserver_name(string tableAlias = "") => new Col_Xserver_name(tableAlias);
            public static Col_Xdttm_ins Xdttm_ins(string tableAlias = "") => new Col_Xdttm_ins(tableAlias);
            public static Col_Xdttm_last_ins_upd Xdttm_last_ins_upd(string tableAlias = "") => new Col_Xdttm_last_ins_upd(tableAlias);
            public static Col_Xfallback_vstart Xfallback_vstart(string tableAlias = "") => new Col_Xfallback_vstart(tableAlias);
            public static Col_Dbid Dbid(string tableAlias = "") => new Col_Dbid(tableAlias);
            public static Col_Segmap Segmap(string tableAlias = "") => new Col_Segmap(tableAlias);
            public static Col_Lstart Lstart(string tableAlias = "") => new Col_Lstart(tableAlias);
            public static Col_Sizepg Sizepg(string tableAlias = "") => new Col_Sizepg(tableAlias);
            public static Col_Vstart Vstart(string tableAlias = "") => new Col_Vstart(tableAlias);
            public class Col_Xserver_name : StringColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "xserver_name";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Xserver_name() { }
                public Col_Xserver_name(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Xdttm_ins : DateTimeColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "xdttm_ins";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Xdttm_ins() { }
                public Col_Xdttm_ins(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Xdttm_last_ins_upd : DateTimeColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "xdttm_last_ins_upd";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Xdttm_last_ins_upd() { }
                public Col_Xdttm_last_ins_upd(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Xfallback_vstart : IntegerColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "xfallback_vstart";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Xfallback_vstart() { }
                public Col_Xfallback_vstart(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Dbid : IntegerColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "dbid";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Dbid() { }
                public Col_Dbid(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Segmap : IntegerColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "segmap";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Segmap() { }
                public Col_Segmap(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Lstart : IntegerColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "lstart";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Lstart() { }
                public Col_Lstart(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Sizepg : IntegerColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "sizepg";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Sizepg() { }
                public Col_Sizepg(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
            public class Col_Vstart : IntegerColumn<TblSpt_fallback_usg>, ISelectColumn<TblSpt_fallback_usg>, ISelectColumnAlias<TblSpt_fallback_usg>
            {
                private readonly string _name = "vstart";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Vstart() { }
                public Col_Vstart(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_fallback_usg> As(string name) => new AliasColumn<TblSpt_fallback_usg>(this, name);
                public override ISelectColumn<TblSpt_fallback_usg> Count() => new CountColumn<TblSpt_fallback_usg>(this);
            }
        }
    }
}
