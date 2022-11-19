using TypeProofSql;
using TypeProofSql.Columns;

namespace test.testna
{
    public class TblCards : ITable{
        string ITable.Name() => "cards";
        public static Col_Id Id() => new Col_Id();
        public static Col_Id Id(string tableAlias) => new Col_Id(tableAlias);
        public static Col_Name Name() => new Col_Name();
        public static Col_Name Name(string tableAlias) => new Col_Name(tableAlias);
        public static Col_Number Number() => new Col_Number();
        public static Col_Number Number(string tableAlias) => new Col_Number(tableAlias);
        public static Col_Number_unique Number_unique() => new Col_Number_unique();
        public static Col_Number_unique Number_unique(string tableAlias) => new Col_Number_unique(tableAlias);
        public static Col_Series_code Series_code() => new Col_Series_code();
        public static Col_Series_code Series_code(string tableAlias) => new Col_Series_code(tableAlias);
        public static Col_Type Type() => new Col_Type();
        public static Col_Type Type(string tableAlias) => new Col_Type(tableAlias);
        public static Col_Level Level() => new Col_Level();
        public static Col_Level Level(string tableAlias) => new Col_Level(tableAlias);
        public static Col_Image Image() => new Col_Image();
        public static Col_Image Image(string tableAlias) => new Col_Image(tableAlias);
        public static Col_Form Form() => new Col_Form();
        public static Col_Form Form(string tableAlias) => new Col_Form(tableAlias);
        public static Col_Attribute Attribute() => new Col_Attribute();
        public static Col_Attribute Attribute(string tableAlias) => new Col_Attribute(tableAlias);
        public static Col_Digimontype Digimontype() => new Col_Digimontype();
        public static Col_Digimontype Digimontype(string tableAlias) => new Col_Digimontype(tableAlias);
        public static Col_Dp Dp() => new Col_Dp();
        public static Col_Dp Dp(string tableAlias) => new Col_Dp(tableAlias);
        public static Col_Playcost Playcost() => new Col_Playcost();
        public static Col_Playcost Playcost(string tableAlias) => new Col_Playcost(tableAlias);
        public static Col_Digivolve1cost Digivolve1cost() => new Col_Digivolve1cost();
        public static Col_Digivolve1cost Digivolve1cost(string tableAlias) => new Col_Digivolve1cost(tableAlias);
        public static Col_Digivolve2cost Digivolve2cost() => new Col_Digivolve2cost();
        public static Col_Digivolve2cost Digivolve2cost(string tableAlias) => new Col_Digivolve2cost(tableAlias);
        public static Col_Effect Effect() => new Col_Effect();
        public static Col_Effect Effect(string tableAlias) => new Col_Effect(tableAlias);
        public static Col_Digivolveeffect Digivolveeffect() => new Col_Digivolveeffect();
        public static Col_Digivolveeffect Digivolveeffect(string tableAlias) => new Col_Digivolveeffect(tableAlias);
        public static Col_Securityeffect Securityeffect() => new Col_Securityeffect();
        public static Col_Securityeffect Securityeffect(string tableAlias) => new Col_Securityeffect(tableAlias);
        public static Col_Notes Notes() => new Col_Notes();
        public static Col_Notes Notes(string tableAlias) => new Col_Notes(tableAlias);
        public static Col_Pack_id Pack_id() => new Col_Pack_id();
        public static Col_Pack_id Pack_id(string tableAlias) => new Col_Pack_id(tableAlias);
        public class Col_Id : IntegerColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "id";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Id() { }
            public Col_Id(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Name : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "name";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Name() { }
            public Col_Name(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Number : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "number";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Number() { }
            public Col_Number(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Number_unique : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "number_unique";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Number_unique() { }
            public Col_Number_unique(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Series_code : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "series_code";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Series_code() { }
            public Col_Series_code(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Type : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "type";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Type() { }
            public Col_Type(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Level : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "level";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Level() { }
            public Col_Level(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Image : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "image";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Image() { }
            public Col_Image(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Form : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "form";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Form() { }
            public Col_Form(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Attribute : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "attribute";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Attribute() { }
            public Col_Attribute(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Digimontype : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "digimontype";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Digimontype() { }
            public Col_Digimontype(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Dp : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "dp";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Dp() { }
            public Col_Dp(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Playcost : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "playcost";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Playcost() { }
            public Col_Playcost(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Digivolve1cost : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "digivolve1cost";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Digivolve1cost() { }
            public Col_Digivolve1cost(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Digivolve2cost : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "digivolve2cost";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Digivolve2cost() { }
            public Col_Digivolve2cost(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Effect : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "effect";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Effect() { }
            public Col_Effect(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Digivolveeffect : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "digivolveeffect";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Digivolveeffect() { }
            public Col_Digivolveeffect(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Securityeffect : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "securityeffect";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Securityeffect() { }
            public Col_Securityeffect(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Notes : StringColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "notes";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Notes() { }
            public Col_Notes(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
        public class Col_Pack_id : IntegerColumn<TblCards>, ISelectColumn<TblCards>, ISelectColumnAlias<TblCards>
        {
            private readonly string _name = "pack_id";
            string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            readonly string? TableAlias;
            public Col_Pack_id() { }
            public Col_Pack_id(string tableAlias) { this.TableAlias = tableAlias; }
            public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
            public override ISelectColumnAlias<TblCards> As(string name) => new AliasColumn<TblCards>(this, name);
            public override ISelectColumn<TblCards> Count() => new CountColumn<TblCards>(this);
        }
    }
}
