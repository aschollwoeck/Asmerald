// See https://aka.ms/new-console-template for more information


using IniParser.Model;
using IniParser.Parser;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using TypeProofSql;
using TypeProofSql.SourceGenerator;
using TypeProofSql.SourceGenerator.Generators;

var providers = new string[] { "SQLite" };

var parser = new IniParser.Parser.IniDataParser(new IniParser.Model.Configuration.IniParserConfiguration()
{
    KeyValueAssigmentChar = '=',
    AllowDuplicateKeys = true,
});

foreach (var provider in providers)
{
    // Load definitions from config file
    var iniData = parser.Parse(File.ReadAllText(Path.Combine(provider, "classDefinition")));
    var dir = iniData.Global["Directory"];
    var tDir = iniData.Global["TestDirectory"];

    // Get the current SQL dialect, e.g. SQLite, etc. for namespace and folder name
    if (System.IO.Directory.Exists(Path.Combine(dir, "Statements")) == false) System.IO.Directory.CreateDirectory(Path.Combine(dir, "Statements"));
    if (System.IO.Directory.Exists(Path.Combine(dir, "Extensions")) == false) System.IO.Directory.CreateDirectory(Path.Combine(dir, "Extensions"));
    var stmtDir = System.IO.Directory.CreateDirectory(Path.Combine(dir, "Statements", iniData.Global["sqlDialect"]));
    stmtDir.GetFiles().ToList().ForEach(f => f.Delete());
    var extDir = System.IO.Directory.CreateDirectory(Path.Combine(dir, "Extensions", iniData.Global["sqlDialect"]));
    extDir.GetFiles().ToList().ForEach(f => f.Delete());
    var testDir = new System.IO.DirectoryInfo(tDir);

    Dictionary<string, GenerateCodeStatement> classNames = new();
    Dictionary<string, GenerateCodeStatement> commonClassNames = new();

    // Prepare DSL
    foreach (var item in iniData.Sections["COMMON_CLASSES"])
    {
        var gen = new GenerateCodeStatement() { class_name = item.KeyName, class_name_short = item.KeyName, full_class_name = item.KeyName };
        classNames.Add(item.KeyName, gen);
        commonClassNames.Add(item.KeyName, gen);
    }

    // Create classes based on definitions
    foreach (var item in iniData.Sections["CLASSES"])
    {
        var code = BuildClass(iniData, classNames, item.KeyName, item.Value);
        classNames.Add(item.KeyName, code);

        // Write code to file
        var filename = code.class_name;
        if (code.generics != null)
        {
            filename = filename + String.Join(", ", code.generics);
        }
        var generatedCode = new TypeProofSql.SourceGenerator.Generators.ClassGenerator().Generate(code);
        File.WriteAllText(System.IO.Path.Combine(stmtDir.FullName, filename + ".cs"), generatedCode);
    }

    var genImplTest = new TestGenerator().Generate(
        "NotImplementedTest",
        classNames
            .Where(c => commonClassNames.ContainsKey(c.Key) == false)
            .Select(c => c.Value));

    //Write test to file
    File.WriteAllText(System.IO.Path.Combine(testDir.FullName, "NotImplementedTest") + ".cs", genImplTest);

    //Now do create extension methods for chaining
    var ext = GetExtensions(iniData, Path.Combine(provider, "classDefinition"), classNames);
    foreach (var genCode in ext)
    {
        var generatedCode = new TypeProofSql.SourceGenerator.Generators.ExtensionGenerator().Generate(genCode);

        //Write code to file
        File.WriteAllText(System.IO.Path.Combine(extDir.FullName, genCode.extension_name + "Extensions") + ".cs", generatedCode);
    }
}

IEnumerable<GenerateExtensionCodeStatement> GetExtensions(IniData iniData, string extDefPath, Dictionary<string, GenerateCodeStatement> classNames)
{
    MermaidReader mermaidReader = new MermaidReader();
    var mermaidRes = mermaidReader.Parse(new StreamReader(extDefPath));

    return mermaidRes.GroupBy(ext => ext.method)
        .Select(ext => new GenerateExtensionCodeStatement()
        {
            nspace = iniData.Global["sqlDialect"],
            extension_name = ext.Key,
            extensions = ext.Select(e => new GenerateExtensionCodeStatement.Extension()
            {
                base_class = classNames[e.baseClass],
                return_class_name = classNames[e.retClass],
                generic_types = JoinLists(classNames[e.retClass].generics, classNames[e.baseClass].generics).ToList()
            }).ToList()
        }).ToList();
}

IEnumerable<T> JoinLists<T>(IEnumerable<T> l1, IEnumerable<T> l2)
{
    List<T> res = new List<T>();

    if (l1 != null) res.AddRange(l1);
    if (l2 != null) res.AddRange(l2);

    return res.Distinct();
}

List<int> FindParaCommas(string paras)
{
    List<int> commas = new List<int>();
    // (ISelectColumn<T1> col1, ISelectColumn<T2> col2)[] on
    // ITable table

    int commaRelevant = 0;
    for (int i = 0; i < paras.Length; i++)
    {
        var c = paras[i];
        if(c == '(')
        {
            commaRelevant++;
        }
        else if(c == ')')
        {
            commaRelevant--;
        }
        else if(c == ',' && commaRelevant == 0)
        {
            commas.Add(i);
        }
    }

    return commas;
}

GenerateCodeStatement ParseClass(IniData iniData, string classDef)
{
    classDef = classDef.Trim();
    // ConditionalJoin<T1, T2>((ISelectColumn<T1> col1, ISelectColumn<T2> col2)[] on)
    // Join<T1, T2>()
    // ConditionalJoin
    // Into<T>()
    // Update(ITable table)

    GenerateCodeStatement statement = new GenerateCodeStatement()
    {
        nspace = iniData.Global["sqlDialect"]
    };

    int bIdx = classDef.IndexOf('(');
    if(bIdx > 0)
    {
        statement.full_class_name = classDef.Substring(0, bIdx).Trim();

        var gIdx = statement.full_class_name.IndexOf('<');
        if(gIdx == -1)
        {
            gIdx = statement.full_class_name.Length;
        }
        statement.class_name_short = statement.full_class_name;
        statement.full_class_name = statement.full_class_name.Insert(gIdx, "Statement");
    }
    else
    {
        statement.class_name_short = classDef;
        statement.full_class_name = classDef + "Statement";
    }

    var name_split = statement.full_class_name.ToString().Split('<', '>').Where(s => !String.IsNullOrEmpty(s));
    var onlyClassName = name_split.First().FirstCharToUpper().ToString();
    statement.class_name = onlyClassName;

    // Wenn parameters are existing
    if(bIdx > 0 && classDef[bIdx + 1] != ')')
    {
        var paraString = classDef.Substring(bIdx + 1, classDef.Length -1 - bIdx - 1);
        var commas = FindParaCommas(paraString);
        var paras = new List<string>();
        int lastComma = 0;
        for (int i = 0; i < commas.Count; i++)
        {
            lastComma = commas[i] + 1;
            if(i == 0)
            {
                paras.Add(paraString.Substring(0, commas[i]));
            }
            else
            {
                paras.Add(paraString.Substring(commas[i - 1] + 1, commas[i] - commas[i - 1] - 1).Trim());
            }
        }

        paras.Add(paraString.Substring(lastComma, paraString.Length - lastComma).Trim());

        statement.properties = paras.Select(para =>
        {
            var sepIdx = para.LastIndexOf(' ');
            var keyValue = para.SplitAt(sepIdx);
            var clsName = keyValue[0];
            var propName = keyValue[1].FirstCharToUpper();

            if (para.Contains("[]"))
            {
                clsName = keyValue[0].Replace("[]", "").FirstCharToUpper();

                return new GenerateCodeProperty()
                {
                    is_list = true,
                    class_name = clsName,
                    prop = propName,
                    para = propName.FirstCharToLower()
                };
            }

            return new GenerateCodeProperty()
            {
                is_list = false,
                class_name = clsName,
                prop = propName,
                para = propName.FirstCharToLower()
            };
        }).ToList();
    }

    statement.generics = statement.full_class_name
                         .Split('<', '>')
                         .Where(s => !String.IsNullOrEmpty(s))
                         .Skip(1)
                         .FirstOrDefault()?
                         .Split(',')
                         .Select(s => s.Trim())
                         .ToList();

    return statement;
}

GenerateCodeStatement BuildClass(IniData iniData, Dictionary<string, GenerateCodeStatement> classNames, string name, string value) 
{
    // ConditionalJoin<T1, T2> = ConditionalJoin<T1, T2>((ISelectColumn<T1> col1, ISelectColumn<T2> col2)[] on) : Join<T1, T2>()
    var classDef = value.Split(':');

    GenerateCodeStatement generateCodeStatement = ParseClass(iniData, classDef[0]);


    if (classDef.Length > 1)
    {
        var baseCls = classDef[1].Trim();

        GenerateCodeBaseClass baseClass = new GenerateCodeBaseClass();
        var bIdx = baseCls.IndexOf('(');
        if (bIdx > 0)
        {
            baseClass.full_class_name = baseCls.Substring(0, bIdx).Trim();

            var gIdx = baseClass.full_class_name.IndexOf('<');
            if (gIdx == -1)
            {
                gIdx = baseClass.full_class_name.Length;
            }
            baseClass.class_name_short = baseClass.full_class_name;
            baseClass.full_class_name = baseClass.full_class_name.Insert(gIdx, "Statement");


            baseClass.parameters = baseCls
                .Substring(bIdx + 1, baseCls.Length - bIdx - 2)
                .Trim()
                .Split(',')
                .Select(s => s.Trim())
                .Where(s => !String.IsNullOrEmpty(s))
                .ToList();
        }
        else
        {
            baseClass.class_name_short = baseCls;
            baseClass.full_class_name = baseCls + "Statement";
        }

        if (classNames.ContainsKey(baseClass.class_name_short))
        {
            var b = classNames[baseClass.class_name_short];
            baseClass.base_class = b;
        }

        generateCodeStatement.inherit_class = baseClass;
    }

    return generateCodeStatement;
}