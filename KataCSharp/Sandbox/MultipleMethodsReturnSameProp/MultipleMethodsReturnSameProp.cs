using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.MultipleMethodsReturnSameProp
{
    public class MultipleMethodsReturnSameProp
    {

        public string GetString()
        {
            var class2 = new Class2();
            return class2.GetString2();


        }

    }

    public class Class2
    {
        public string GetString2()
        {
            var class3 = new Class3();
            return class3.GetString3();
        }
    }



    public class Class3
    {
        public string GetString3()
        {
            return "test string";
        }
    }


}
