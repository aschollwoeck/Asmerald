// See https://aka.ms/new-console-template for more information


using System.Reflection;
using System.Text;
using System.Xml.Linq;
using TypeProofSql;
using TypeProofSql.SourceGenerator;
using TypeProofSql.SourceGenerator.Generators;

var parser = new IniParser.Parser.IniDataParser(new IniParser.Model.Configuration.IniParserConfiguration()
{
    KeyValueAssigmentChar = '=',
    AllowDuplicateKeys = true,
});

// Load definitions from config file
var iniSqlite = parser.Parse(File.ReadAllText("sqlite_definition"));
var dir = iniSqlite.Global["Directory"];
var tDir = iniSqlite.Global["TestDirectory"];

// Get the current SQL dialect, e.g. SQLite, etc. for namespace and folder name
if (System.IO.Directory.Exists(Path.Combine(dir, "Statements")) == false) System.IO.Directory.CreateDirectory(Path.Combine(dir, "Statements"));
if (System.IO.Directory.Exists(Path.Combine(dir, "Extensions")) == false) System.IO.Directory.CreateDirectory(Path.Combine(dir, "Extensions"));
var stmtDir = System.IO.Directory.CreateDirectory(Path.Combine(dir, "Statements", iniSqlite.Global["sqlDialect"]));
stmtDir.GetFiles().ToList().ForEach(f => f.Delete());
var extDir = System.IO.Directory.CreateDirectory(Path.Combine(dir, "Extensions", iniSqlite.Global["sqlDialect"]));
extDir.GetFiles().ToList().ForEach(f => f.Delete());
var testDir = new System.IO.DirectoryInfo(tDir);

Dictionary<string, GenerateCodeStatement> classNames = new();
Dictionary<string, GenerateCodeStatement> commonClassNames = new();

// Prepare DSL
foreach (var item in iniSqlite.Sections["COMMON_CLASSES"])
{
    var gen = new GenerateCodeStatement() { class_name = item.KeyName, class_name_short = item.KeyName, full_class_name = item.KeyName };
    classNames.Add(item.KeyName, gen);
    commonClassNames.Add(item.KeyName, gen);
}

//var classTemplate = ReadResource("classGeneration.txt");
//var classTemplateParsed = Scriban.Template.ParseLiquid(classTemplate);

// Create classes based on definitions
foreach (var item in iniSqlite.Sections["CLASSES"])
{
    var code = BuildClass(item.KeyName, item.Value);
    classNames.Add(item.KeyName, code);
}

var genImplTest = new TestGenerator().Generate(
    "NotImplementedTest",
    classNames
        .Where(c => commonClassNames.ContainsKey(c.Key) == false)
        .Select(c => c.Value));

//Write test to file
File.WriteAllText(System.IO.Path.Combine(testDir.FullName, "NotImplementedTest") + ".cs", genImplTest);


//var extensionTemplate = ReadResource("extensionGeneration.txt");
//var extensionTemplateParsed = Scriban.Template.ParseLiquid(extensionTemplate);




// Now chain classes together with extension methods
//foreach (var item in iniSqlite.Sections["CHAINING"])
//{
    // Now do create extension methods for chaining
    //var ext = BuildExtensions(item.KeyName, item.Value.Split(';').Select(s => s.Trim()));

    //var generatedCode = new TypeProofSql.SourceGenerator.Generators.ExtensionGenerator().Generate(e);

    //var generatedCode = extensionTemplateParsed.RenderAsync(new { nspace = iniSqlite.Global["sqlDialect"], extension_name = extension_name, extensions = extensions });

    // Write code to file
    //File.WriteAllText(System.IO.Path.Combine(extDir.FullName, extension_name + "Extensions") + ".cs", generatedCode);
//}

//Now do create extension methods for chaining
var ext = GetExtensions();
foreach (var genCode in ext)
{
    var generatedCode = new TypeProofSql.SourceGenerator.Generators.ExtensionGenerator().Generate(genCode);

    //Write code to file
    File.WriteAllText(System.IO.Path.Combine(extDir.FullName, genCode.extension_name + "Extensions") + ".cs", generatedCode);
}



//GenerateExtensionCodeStatement BuildExtensions(string name, IEnumerable<string> values)
//{
//    // Prepare Scriban properties
//    var extension_name = name.FirstCharToUpper();
//    var extensions = values.Select(v => {

//        var classes = v.Split(":");

//        var baseClass = classes[0].Trim();
//        var returnClass = classes[1].Trim();

//        if (!classNames.ContainsKey(baseClass))
//        {
//            throw new NotImplementedException($"Class '{baseClass}' is not yet defined!");
//        }

//        if (!classNames.ContainsKey(returnClass))
//        {
//            throw new NotImplementedException($"Class '{returnClass}' is not yet defined!");
//        }

//        //return_class_name
//        //base_class
//        //paras

//        return new { return_class_name = classNames[returnClass], base_class = classNames[baseClass] };
//    }).ToList();

//    // Now generate code
//    var e = new GenerateExtensionCodeStatement()
//    {
//        nspace = iniSqlite.Global["sqlDialect"],
//        extension_name = extension_name,
//        extensions = extensions
//        .Select(e => new GenerateExtensionCodeStatement.Extension()
//        {
//            base_class = e.base_class,
//            return_class_name = e.return_class_name
//        })
//        .ToList()
//    };
//}

IEnumerable<GenerateExtensionCodeStatement> GetExtensions()
{
    MermaidReader mermaidReader = new MermaidReader();
    var mermaidRes = mermaidReader.Parse(new StreamReader("mermaid.txt"));

    return mermaidRes.GroupBy(ext => ext.method)
        .Select(ext => new GenerateExtensionCodeStatement()
        {
            nspace = iniSqlite.Global["sqlDialect"],
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

GenerateCodeStatement ParseClass(string classDef)
{
    classDef = classDef.Trim();
    // ConditionalJoin<T1, T2>((ISelectColumn<T1> col1, ISelectColumn<T2> col2)[] on)
    // Join<T1, T2>()
    // ConditionalJoin
    // Into<T>()
    // Update(ITable table)

    GenerateCodeStatement statement = new GenerateCodeStatement()
    {
        nspace = iniSqlite.Global["sqlDialect"]
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

GenerateCodeStatement BuildClass(string name, string value) 
{
    // ConditionalJoin<T1, T2> = ConditionalJoin<T1, T2>((ISelectColumn<T1> col1, ISelectColumn<T2> col2)[] on) : Join<T1, T2>()
    var classDef = value.Split(':');

    GenerateCodeStatement generateCodeStatement = ParseClass(classDef[0]);


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

    var generatedCode = new TypeProofSql.SourceGenerator.Generators.ClassGenerator().Generate(generateCodeStatement);

    // Now generate code via Scriban!
    //var generatedCode = classTemplateParsed.RenderAsync(new { nspace = iniSqlite.Global["sqlDialect"], class_gen = generateCodeStatement });

    // Write code to file
    var filename = generateCodeStatement.class_name;
    if(generateCodeStatement.generics != null)
    {
        filename = filename + String.Join(", ", generateCodeStatement.generics);
    }
    File.WriteAllText(System.IO.Path.Combine(stmtDir.FullName, filename + ".cs"), generatedCode);

    return generateCodeStatement;
}

string ReadResource(string name)
{
    // Determine path
    var assembly = Assembly.GetExecutingAssembly();
    string resourcePath = name;
    // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
    if (!name.StartsWith(nameof(TypeProofSql)))
    {
        resourcePath = assembly.GetManifestResourceNames()
            .Single(str => str.EndsWith(name));
    }

    using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
    using (StreamReader reader = new StreamReader(stream))
    {
        return reader.ReadToEnd();
    }
}