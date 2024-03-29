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
        public static Fn_ISOweek ISOweek(System.DateTime @DATE) => new Fn_ISOweek(@DATE);
        public class Fn_ISOweek : Asmerald.Functions.IFunction<System.Int32>
        {
            public string Name() => "dbo.ISOweek";
            
            private readonly System.DateTime @DATE;
            
            public Fn_ISOweek(System.DateTime @DATE)
            {
                this.@DATE = @DATE;
            }
            
            public System.Collections.Generic.List<(string, object)> GetParameters()
            {
                return new System.Collections.Generic.List<(string, object)>()
                {
                    ("@DATE", @DATE)
                };
            }
        }
    }
}
