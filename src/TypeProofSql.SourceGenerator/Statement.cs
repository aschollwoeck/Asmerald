using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.SourceGenerator
{
    internal class GenerateCodeStatement
    {
        public string nspace { get; set; } = "";
        public string class_name { get; set; } = "";
        public string full_class_name { get; set; } = "";
        public string class_name_short { get; set; } = "";

        public GenerateCodeBaseClass inherit_class { get; set; }

        public List<GenerateCodeProperty> properties = new();
        public List<string> generics = new();
    }

    internal class GenerateCodeBaseClass
    {
        public string class_name { get; set; } = "";
        public string full_class_name { get; set; } = "";
        public string class_name_short { get; set; } = "";
        public List<string> parameters = new();
        public GenerateCodeStatement base_class { get; set; }
    }

    internal class GenerateCodeProperty
    {
        public bool is_generic { get; set; } = false;
        public bool is_list { get; set; } = false;
        public string class_name { get; set; } = "";
        public string prop { get; set; } = "";
        public string para { get; set; } = "";
    }

    internal class GenerateExtensionCodeStatement
    {
        public string nspace { get; set; } = "";
        public string extension_name { get; set; } = "";
        public List<Extension> extensions { get; set; } = new List<Extension>();
        public override string ToString()
        {
            return extension_name;
        }

        internal class Extension
        {
            public GenerateCodeStatement base_class { get; set; }
            public GenerateCodeStatement return_class_name { get; set; }
            public List<string> generic_types { get; set; } = new List<string>();
        }
    }

    //internal class GenerateCodeGeneric
    //{
    //    public string type { get; set; } = "";
    //}
}
