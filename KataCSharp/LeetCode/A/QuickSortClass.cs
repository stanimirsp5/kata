using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeetCode
{
    internal class QuickSortClass
    {
        public void MyMain()
        {
            int[] arr = new int[] { 6, 2, 4, 5, 1, 3 };
            int lo = 0;
            int hi = arr.Length - 1;
           //var t = Partition(arr, lo, hi);
            QuickSort(arr, lo, hi);
        }

        public void QuickSort(int[] arr, int lo, int hi)
        {
            if (lo > hi) return;
            int partition = Partition(arr,lo,hi);
            QuickSort(arr,lo, partition-1);
            QuickSort(arr,partition+1, hi);

        }

        public int Partition(int[] arr, int lo, int hi)
        {

            int pivot = arr[hi];
            int k = lo-1;
            for (int i = lo; i < hi; i++)
            {

                if(arr[i] < pivot)
                {
                    k++;//0,1
                    Swap(arr, i, k);

                }
            }
            Swap(arr, ++k, hi);

            return k;
        }

        private void Swap(int[] arr, int i, int k)
        {
            int temp = arr[i];
            arr[i] = arr[k];
            arr[k] = temp;
        }


    }
}
