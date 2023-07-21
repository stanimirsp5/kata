using KataCSharp.Algorithms.Sorting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            //var res = list.OrderByComparer(x => x);
            var res1 = list.COrderBy();

            
            var oc = new OrderedCollection<int>(list);
            foreach (var item in oc)
            {
                Console.Write(item + ", ");
            }

            //var res = oc.MyOrderBy(list, x => x > 0);
        }
    }
    // 7, 3, 1, 2, 9,  5, 6,  4, 8
    public static class OrderByImpl
    {
        /// <summary>
        /// Order using sorting algorithm
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        public static IEnumerable<T> OrderByComparer<T,TRes>(this IEnumerable<T> source, Func<T,TRes> keySelector)
        {
            var comparer = Comparer<TRes>.Default;
            var list = new List<T>(source);
            list.Sort((x,y) => comparer.Compare(keySelector(x), keySelector(y)));
            return list;

        }
    }

    /// <summary>
    /// Order using iteration
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class OrderedCollection<T> : IEnumerable
    {
        List<T> list { get; set; }

        public OrderedCollection(List<T> list)
        {
            this.list = list;
        }

        public IEnumerator GetEnumerator()
        {
            List<int> elements = list.Select(el => int.Parse(el.ToString())).ToList();
            while(elements.Count > 0)
            {
                int minIndex = 0;
                int smallestNum = elements.FirstOrDefault();
                for (int i = 0; i < elements.Count; i++)
                {
                    if (smallestNum.CompareTo(elements[i]) == 1)
                    {
                        smallestNum = elements[i];
                        minIndex = i;
                    }
                }
                elements.RemoveAt(minIndex);
                yield return smallestNum;
            }
        }
    }
}
