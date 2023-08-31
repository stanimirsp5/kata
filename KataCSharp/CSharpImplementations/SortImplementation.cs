using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KataCSharp.CSharpImplementations.CommonObjects;

namespace KataCSharp.CSharpImplementations
{
    public class SortImplementation
    {
        public void Start()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var emp = CommonObjects.CreateEmployees();
            emp.Sort(SortByEmployeeIdHelper.SortById());
            var t = list.MySort();
        }


    }

    public static class CustomCollections
    {
        public static IEnumerable<T> MySort<T>(this IEnumerable<T> source)
        {
            var list = source.ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                //TODO use comparison
                var smallestNum = list[i];
                //if (list.com(list[i], list[i]))
                //{

                //}

            }



            return source;
        }
    }
    public class SortByEmployeeIdHelper : IComparer<Employee>
    {
        public static IComparer<Employee> SortById()
        {
            return new SortByEmployeeIdHelper();
        }

        public int Compare(Employee? x, Employee? y)
        {
            return ((x is null) || (y is null)) ? 0: y.Id.CompareTo(x.Id);
        }
    }
}
