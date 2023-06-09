using KataCSharp.Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class OrderByImplementation
    {

        public void Start()
        {
            var list = new List<int>() { 7, 3, 1, 2, 9,  5, 6,  4, 8 };
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 20 },
                new Person { Name = "David", Age = 35 }
            };
            
            //  var t = InsertionSort(list);
            var res = list.COrderBy2(x => x);
            var res2 = list.OrderBy(x => x > 0);
            list.Sort();
            list.FindAll(x => x > 4);
            //res.ToList().ForEach(el => Console.WriteLine(el));
        }

   

    }
    // 7, 3, 1, 2, 9,  5, 6,  4, 8
    public static class OrderByImpl
    {
        public static IEnumerable<int> COrderBy(this IEnumerable<int> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            
            var orderedList = InsertionSort.Sort((List<int>)source);

            foreach (var item in orderedList)
            {
                    yield return item;
            }
        }


        public static IEnumerable<int> COrderBy2(this IEnumerable<int> source, Func<int, int> func)
        {
            var array = source.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                var currNum = array[i];
                var j = i - 1;
               
                while (j >= 0 && array[j] > currNum)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = currNum;

             //   yield return currNum;
            }
            return array;
        }
    }

}
