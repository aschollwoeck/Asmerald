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
        public static StProc_test_proc test_proc() => new StProc_test_proc();
        public class StProc_test_proc : Asmerald.StoredProcedures.IStoredProcedure
        {
            public string Name() => "production.test_proc";
            
            
            public StProc_test_proc()
            {
            }
            
            public System.Collections.Generic.List<(string, object)> GetParameters()
            {
                return new System.Collections.Generic.List<(string, object)>()
                {
                };
            }
        }
    }
}
