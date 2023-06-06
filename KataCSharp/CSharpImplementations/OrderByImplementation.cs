using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class OrderByImplementation
    {
        public void Start()
        {
            var list = new List<int>() { 7, 3, 1, 2, 9,  5, 6,  4, 8 };
          //  var t = InsertionSort(list);
            var res = list.COrderBy(x => x);
            res.ToList().ForEach(el => Console.WriteLine(el));
        }

        /// <summary>
        /// To sort an array of size N in ascending order iterate over the array and compare the current element (key) to its predecessor, 
        /// if the key element is smaller than its predecessor, compare it to the elements before. 
        /// Move the greater elements one position up to make space for the swapped element.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        List<int> InsertionSort(List<int> list)
        {
            var array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                int currNum = array[i];
                int j = i - 1;
                //i-2 j-1
                // 3,7,1
                while (j >= 0 && array[j] > currNum)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j+1]=currNum;
            }

            return array.ToList();
        }

    }

    public static class OrderByImpl
    {
        public static IEnumerable<int> COrderBy(this IEnumerable<int> source, Func<int, int> func)
        {
            var arr = source.ToArray();
            while (true)
            {
                int i = 0;
                int currNum = arr[i];
                int smallestNum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (currNum < arr[j])
                    {

                    }
                }
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
