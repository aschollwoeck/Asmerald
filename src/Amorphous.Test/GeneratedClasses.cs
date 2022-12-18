using Amorphous;
using Amorphous.Columns;


public class Tbl_Packs : ITable
{
    string ITable.Name() => "packs";


    public static Col_Id Id() => new Col_Id();

    public static Col_Name Name() => new Col_Name();

    public static Col_Code Code() => new Col_Code();

    public static Col_Release_date Release_date() => new Col_Release_date();

    public static Col_Series Series() => new Col_Series();

    public static Col_Type Type() => new Col_Type();



    public class Col_Id : IntegerColumn<Tbl_Packs>, ISelectColumn<Tbl_Packs>, ISelectColumnAlias<Tbl_Packs>
    {
        private readonly string _name = "id";

        string ISelectColumn.Name => _name;

        public Col_Id() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Packs> As(string name) => new AliasColumn<Tbl_Packs>(this, name);

        public override ISelectColumn<Tbl_Packs> Count() => new CountColumn<Tbl_Packs>(this);
    }

    public class Col_Name : StringColumn<Tbl_Packs>, ISelectColumn<Tbl_Packs>, ISelectColumnAlias<Tbl_Packs>
    {
        private readonly string _name = "name";

        string ISelectColumn.Name => _name;

        public Col_Name() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Packs> As(string name) => new AliasColumn<Tbl_Packs>(this, name);

        public override ISelectColumn<Tbl_Packs> Count() => new CountColumn<Tbl_Packs>(this);
    }

    public class Col_Code : StringColumn<Tbl_Packs>, ISelectColumn<Tbl_Packs>, ISelectColumnAlias<Tbl_Packs>
    {
        private readonly string _name = "code";

        string ISelectColumn.Name => _name;

        public Col_Code() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Packs> As(string name) => new AliasColumn<Tbl_Packs>(this, name);

        public override ISelectColumn<Tbl_Packs> Count() => new CountColumn<Tbl_Packs>(this);
    }

    public class Col_Release_date : StringColumn<Tbl_Packs>, ISelectColumn<Tbl_Packs>, ISelectColumnAlias<Tbl_Packs>
    {
        private readonly string _name = "release_date";

        string ISelectColumn.Name => _name;

        public Col_Release_date() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Packs> As(string name) => new AliasColumn<Tbl_Packs>(this, name);

        public override ISelectColumn<Tbl_Packs> Count() => new CountColumn<Tbl_Packs>(this);
    }

    public class Col_Series : StringColumn<Tbl_Packs>, ISelectColumn<Tbl_Packs>, ISelectColumnAlias<Tbl_Packs>
    {
        private readonly string _name = "series";

        string ISelectColumn.Name => _name;

        public Col_Series() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Packs> As(string name) => new AliasColumn<Tbl_Packs>(this, name);

        public override ISelectColumn<Tbl_Packs> Count() => new CountColumn<Tbl_Packs>(this);
    }

    public class Col_Type : StringColumn<Tbl_Packs>, ISelectColumn<Tbl_Packs>, ISelectColumnAlias<Tbl_Packs>
    {
        private readonly string _name = "type";

        string ISelectColumn.Name => _name;

        public Col_Type() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Packs> As(string name) => new AliasColumn<Tbl_Packs>(this, name);

        public override ISelectColumn<Tbl_Packs> Count() => new CountColumn<Tbl_Packs>(this);
    }

}

public class Tbl_Cards : ITable
{
    string ITable.Name() => "cards";


    public static Col_Id Id() => new Col_Id();

    public static Col_Name Name() => new Col_Name();

    public static Col_Number Number() => new Col_Number();

    public static Col_Number_unique Number_unique() => new Col_Number_unique();

    public static Col_Series_code Series_code() => new Col_Series_code();

    public static Col_Type Type() => new Col_Type();

    public static Col_Level Level() => new Col_Level();

    public static Col_Image Image() => new Col_Image();

    public static Col_Form Form() => new Col_Form();

    public static Col_Attribute Attribute() => new Col_Attribute();

    public static Col_Digimontype Digimontype() => new Col_Digimontype();

    public static Col_Dp Dp() => new Col_Dp();

    public static Col_Playcost Playcost() => new Col_Playcost();

    public static Col_Digivolve1cost Digivolve1cost() => new Col_Digivolve1cost();

    public static Col_Digivolve2cost Digivolve2cost() => new Col_Digivolve2cost();

    public static Col_Effect Effect() => new Col_Effect();

    public static Col_Digivolveeffect Digivolveeffect() => new Col_Digivolveeffect();

    public static Col_Securityeffect Securityeffect() => new Col_Securityeffect();

    public static Col_Notes Notes() => new Col_Notes();

    public static Col_Pack_id Pack_id() => new Col_Pack_id();



    public class Col_Id : IntegerColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "id";

        string ISelectColumn.Name => _name;

        public Col_Id() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Name : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "name";

        string ISelectColumn.Name => _name;

        public Col_Name() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Number : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "number";

        string ISelectColumn.Name => _name;

        public Col_Number() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Number_unique : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "number_unique";

        string ISelectColumn.Name => _name;

        public Col_Number_unique() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Series_code : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "series_code";

        string ISelectColumn.Name => _name;

        public Col_Series_code() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Type : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "type";

        string ISelectColumn.Name => _name;

        public Col_Type() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Level : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "level";

        string ISelectColumn.Name => _name;

        public Col_Level() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Image : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "image";

        string ISelectColumn.Name => _name;

        public Col_Image() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Form : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "form";

        string ISelectColumn.Name => _name;

        public Col_Form() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Attribute : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "attribute";

        string ISelectColumn.Name => _name;

        public Col_Attribute() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Digimontype : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "digimontype";

        string ISelectColumn.Name => _name;

        public Col_Digimontype() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Dp : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "dp";

        string ISelectColumn.Name => _name;

        public Col_Dp() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Playcost : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "playcost";

        string ISelectColumn.Name => _name;

        public Col_Playcost() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Digivolve1cost : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "digivolve1cost";

        string ISelectColumn.Name => _name;

        public Col_Digivolve1cost() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Digivolve2cost : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "digivolve2cost";

        string ISelectColumn.Name => _name;

        public Col_Digivolve2cost() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Effect : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "effect";

        string ISelectColumn.Name => _name;

        public Col_Effect() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Digivolveeffect : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "digivolveeffect";

        string ISelectColumn.Name => _name;

        public Col_Digivolveeffect() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Securityeffect : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "securityeffect";

        string ISelectColumn.Name => _name;

        public Col_Securityeffect() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Notes : StringColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "notes";

        string ISelectColumn.Name => _name;

        public Col_Notes() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

    public class Col_Pack_id : IntegerColumn<Tbl_Cards>, ISelectColumn<Tbl_Cards>, ISelectColumnAlias<Tbl_Cards>
    {
        private readonly string _name = "pack_id";

        string ISelectColumn.Name => _name;

        public Col_Pack_id() { }

        public override string Name() => _name;

        public override ISelectColumnAlias<Tbl_Cards> As(string name) => new AliasColumn<Tbl_Cards>(this, name);

        public override ISelectColumn<Tbl_Cards> Count() => new CountColumn<Tbl_Cards>(this);
    }

}
