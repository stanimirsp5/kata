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
            var orderPeople = people.OrderBy(p => p.Age);
            var res1 = list.COrderBy();

            
            var oc = new OrderedCollection<Person, int>(people, p => p.Age);
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

    public delegate void FuncDel(string msg);
    /// <summary>
    /// Order using iteration
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class OrderedCollection<T, TRes> : IEnumerable
    {
        List<T> list { get; set; }
        Func<T, TRes> func { get; set; }

        public OrderedCollection(List<T> list, Func<T,TRes> func)
        {
            this.list = list;
            this.func = func;
        }

        public IEnumerator GetEnumerator()
        {
            List<T> elements = list.ToList();
            while(elements.Count > 0)
            {
                int minIndex = 0;
                var smallestNum = func(elements.FirstOrDefault());
                for (int i = 0; i < elements.Count; i++)
                {
                    var item = func(elements[i]);
                    var comparer = Comparer<TRes>.Default.Compare(smallestNum, item);
                    if (comparer == 1)
                    {
                        smallestNum = item;
                        minIndex = i;
                    }
                }
                elements.RemoveAt(minIndex);
                yield return smallestNum;
            }
        }
        //public IEnumerator GetEnumerator()
        //{
        //    List<T> elements = list.ToList();
        //    while(elements.Count > 0)
        //    {
        //        int minIndex = 0;
        //        var smallestNum = elements.FirstOrDefault();
        //        for (int i = 0; i < elements.Count; i++)
        //        {
        //            var item = func(elements[i]);
        //            var comparer = Comparer<T>.Default.Compare(smallestNum, elements[i]);
        //            if (comparer == 1)
        //            {
        //                smallestNum = elements[i];
        //                minIndex = i;
        //            }
        //        }
        //        elements.RemoveAt(minIndex);
        //        yield return smallestNum;
        //    }
        //}
    }
}
