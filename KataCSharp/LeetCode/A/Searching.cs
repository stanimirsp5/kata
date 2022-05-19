using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeetCode
{
    public class Searching
    {
        public void MyMain()
        {
            //int[] arr = new int[] { 6, 2, 4, 5, 3, 1 };
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int mid = arr.Length / 2;
            int num = 1;
            var idx = BinarySearch(arr, 0, arr.Length-1, num);
        }

        public int BinarySearch(int[] arr, int lo, int hi, int num)//7 9
        {
            if(lo > hi) return -1;
            int mid = lo + (hi - lo) / 2;
            if(num == arr[mid]) return mid;
            if (num > arr[mid]) return BinarySearch(arr, mid+1, hi, num);
            else return BinarySearch(arr, lo, mid, num);
        }


        public int IndexOf(int[] arr,int num)
        {
            int index = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
