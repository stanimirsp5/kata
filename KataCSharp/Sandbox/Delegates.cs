using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox
{
    public delegate void MyMessage(string msg);
    public delegate int SumDelegate(int num1, int num2);

    public class Delegates
    {
        public void Start()
        {
            MyMessage del = ClassA.Print;
            del("test");
            MyMessage del2 = (string msg ) => Console.WriteLine(msg);

            SumDelegate sumDel = (int num1, int num2) => num1 + num2;
            int num = sumDel(1,6);

        }
    }

    public class ClassA
    {
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
