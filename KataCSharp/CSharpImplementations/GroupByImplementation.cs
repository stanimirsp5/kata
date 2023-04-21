using KataCSharp.CSharpImplementations.SelectMany;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static KataCSharp.CSharpImplementations.CommonObjects;
using Employee = KataCSharp.CSharpImplementations.CommonObjects.Employee;

namespace KataCSharp.CSharpImplementations
{
    public class GroupByImplementation
    {
        public GroupByImplementation()
        {

        }
        public void Start()
        {
            GroupEmployeesByCompany();
        }

        void GroupEmployeesByCompany()
        {
            var employees = CreateEmployees();

            var groupedEmployees = employees.GroupBy(em => em.Position);
            foreach (var group in groupedEmployees)
            {
                foreach (var item in group)
                {

                }
            }

            var groupedEmployeesQuery = from employee in employees
                                        group employee by employee.Position;

            // var myGroupedElements = MyGroupBy<string, Employee>(employees, em => em.Position);
            var myGroupedElements = employees.MyGroupBy<string, Employee>(em => em.Position);

            foreach (var myEmployees in myGroupedElements)
            {
                foreach (var item in myEmployees)
                {

                }
            }


        }
    }

    public static class MyGroupByImpl
    {
        public static IEnumerable<IMyGrouping<string, TElement>> MyGroupBy<TKey, TElement>(this IEnumerable<TElement> employees, Func<TElement, string> myDelegate)
        {
            IEnumerable<IMyGrouping<string, TElement>> groupedElements = new List<MyGrouping<string, TElement>>();
            foreach (var employee in employees)
            {
                var key = myDelegate(employee);

                var element = groupedElements.FirstOrDefault(el => el.key == key);

                if (element != null)
                {
                    element.elements = element.elements.Append(employee);
                }
                else
                {
                    var myGrouping = new MyGrouping<string, TElement>(key);
                    myGrouping.elements = new List<TElement>() { employee };
                    groupedElements = groupedElements.Append(myGrouping);
                }

            }

            return groupedElements;
        }

    }

    public interface IMyGrouping<TKey, TElement> : IEnumerable<TElement>
    {
        TKey key { get; set; }
        IEnumerable<TElement> elements { get; set; }
    }

    class MyGrouping<TKey, TElement> : IMyGrouping<TKey, TElement>
    {
        TKey _key;
        IEnumerable<TElement> _elements = new List<TElement>();

        public TKey key { get => _key; set => _key = value; }
        public IEnumerable<TElement> elements
        {
            get => _elements;
            set
            {
                _elements = value;
            }
        }

        public MyGrouping(TKey key)
        {
            _key = key;
            //elements = elements.Append(element);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class GroupByEnum : IEnumerator
    {
       // public MyGrouping<TKey, TElement>[] _myGroupings;
        public GroupByEnum()
        {

        }

        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }


    interface ITestable
    {
        void DoTest(int num);

        void Print() => Console.WriteLine("My print message");
    }
    class Test : ITestable
    {
        public Test()
        {
            var print = this as ITestable;
            print.Print();
        }
        void ITestable.DoTest(int num)
        {
            int num1 = 2;
            switch (num1)
            {
                case 1:
                    string name = "My name";
                    break;
                case 2:
                    name = "hi";
                    Console.WriteLine(name);
                    break;
            }

        }
    }

}
