using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static KataCSharp.CSharpImplementations.CommonObjects;

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
            foreach (var group  in groupedEmployees)
            {
                foreach (var item in group)
                {

                }
            }

            var groupedEmployeesQuery = from employee in employees
                                        group employee by employee.Position;

            var myGroupedElements = MyGroupBy<string, Employee>(employees, em => em.Position);
        }


        IEnumerable<IMyGrouping<string, Employee>> MyGroupBy<TKey, TElement>(List<Employee> employees, Func<Employee,string> myDelegate)
        {
            var groupedElements = new List<IMyGrouping<string, Employee>>();
            //groupedElements.Add();
            foreach (var employee in employees)
            {
                var key = myDelegate(employee);
                IMyGrouping<string, Employee> grouping = new MyGrouping<string,Employee>(key, employee);
                //if (groupedElements.HasKey(key))
                //{

                //}
                groupedElements.Add(grouping);
            }

            return groupedElements;
        }

    }

    interface IMyGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable
    {
        TKey key { get; set; }
    }

    class MyGrouping<TKey, TElement> : IMyGrouping<TKey, TElement>, IEnumerable
    {
        TKey _key;
        IEnumerable<TElement> elements = new List<TElement>();
       
        public TKey key { get => _key; set => _key = value; }

        public MyGrouping(TKey key,TElement element)
        {
            _key = key;
            elements.Append(element);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
