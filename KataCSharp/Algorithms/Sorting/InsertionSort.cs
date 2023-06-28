using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Algorithms.Sorting
{
    public class InsertionSort
    {
        public void Start()
        {
            // var list = new List<int>() { 7, 3, 1, 2, 9, 5, 6, 4, 8 };
            var list = new List<int>() { 7, 3, 1, 2 };
            var res = Sort(list);

        }
        /// <summary>
        /// To sort an array of size N in ascending order iterate over the array and compare the current element (key) to its predecessor, 
        /// if the key element is smaller than its predecessor, compare it to the elements before. 
        /// Move the greater elements one position up to make space for the swapped element.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        // 7, 3, 1, 2
        // 3 7 1 2
        // 3 1 7 2
        // 1 3 7 2
        // 1 3 2 7
        // 1 2 3 7

        public static List<int> Sort(List<int> list)
        {

            for (int i = 1; i < list.Count; i++)
            {
                int currNum = i;
                int prevNum = i - 1;
                while (prevNum >= 0 && list[prevNum] > list[currNum])
                {
                    var temp = list[currNum];
                    list[currNum] = list[prevNum];
                    list[prevNum] = temp;

                    currNum--;
                    prevNum--;
                }
            }

            return list;
        }

        public static List<int> InsertionSort2(List<int> list)
        {
            // 3,7,1
            var array = list.ToArray();
            for (int i = 0; i < array.Length; i++)// i=1,2
            {
                int currNum = array[i];// 7,1
                int j = i - 1;//j = 0,1


                while (j >= 0 && array[j] > currNum)// 3 > 7, 7>1/3>1
                {
                    array[j + 1] = array[j];// arr[2] = arr[1]/1=7 3,7,7| arr[1] = arr[0]/ 3,3,7
                    j = j - 1;// 0,-1
                }
                array[j + 1] = currNum;// arr[-1+1] = 1/ arr[0] = 1/ 1,3,7
            }

            return array.ToList();
        }


    }
}
