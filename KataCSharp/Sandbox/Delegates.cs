using KataCSharp.CSharpImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox
{

    public delegate void MyMessage(string msg);
    public delegate int SumDelegate(int num1, int num2);
    public delegate TRes FuncDel<T, TRes>(T items);

    public class Delegates
    {
        public void Start()
        {
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 20 },
                new Person { Name = "David", Age = 35 }
            };

            MyMessage del = ClassA.Print;
            del("test");
            MyMessage del2 = (string msg ) => Console.WriteLine(msg);

            SumDelegate sumDel = (int num1, int num2) => num1 + num2;
            int num = sumDel(1,6);

            FuncDel<Person, int> funcDel = (Person person) => person.Age;
            FuncDel<Person, int> funcDelWithMethod = ClassA.ExtractAgeProperty;

            foreach (var person in people)
            {
                var tt = funcDel(person);
                var tt2 = funcDelWithMethod(person);
            }
        }
    }

    public class ClassA
    {
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        } 

        public static int ExtractAgeProperty(Person person)
        {
            return person.Age;
        }
    }
}
