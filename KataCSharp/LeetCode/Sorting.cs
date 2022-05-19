using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeetCode
{
    internal class Sorting
    {
        private int[] aux;
        public void MyMain()
        {
            int[] arr = new int[] { 6, 2, 4,5,3,1 };
            aux = new int[arr.Length];
            MergeSort(arr, 0, arr.Length);
        }
        public void MergeSort(int[] arr, int lo, int hi)
        {
            if (lo > hi) return;

            int mid = lo + (hi - lo) / 2;
            MergeSort(arr, lo, mid);
            MergeSort(arr, mid + 1, hi);

          //  MergeArr(arr, lo, mid, hi);
        }

        //public void MergeArr(int[] arr, int lo, int mid, int hi)
        //{
        //    for (int i = lo; i < hi; i++)
        //    {
        //        aux[i] = arr[i];
        //    }

            
        //    for (int i = 0; i < length; i++)
        //    {

        //    }


        //}


        public void MergeSort2(int[] arr, int lo, int hi)
        {
            if (hi <= lo) return;

            int mid = lo + (hi-lo) / 2;
            MergeSort(arr, 0, mid);
            MergeSort(arr, mid+1, hi);

            MergeOptimize(arr, lo, mid, hi);
        }   
        // [4,5,6,1,2] lo-0,mid- 2, hi- 5
        public void MergeOptimize(int[] a, int lo, int mid, int hi)
        {
            int i = lo, j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (less(aux[j],aux[i])) a[k] = aux[j++];
                else a[k] = aux[i++];
            }

        }
        private static bool less(int a, int b)
        {
            return a < b;
        }
        public int[] Merge(int[] nums1, int[] nums2, int n, int m)
        {
            for (int i = m, k = 0; i < nums1.Length; i++, k++)
            {
                nums1[i] = nums2[k];
            }
            //[4,5,6,1,2,3]
            for (int i = 0; i < nums1.Length; i++)
            {
                int minIdx = i;//0
                for (int k = i; k < nums1.Length; k++)
                {

                    if (nums1[minIdx] > nums1[k])
                    {
                        minIdx = k;
                    }
                }

                int temp = nums1[i];//4
                nums1[i] = nums1[minIdx];//4=1
                nums1[minIdx] = temp;

            }
            return nums1;
        }

        public int[] MergeAlgorithm(int[] arr1, int[] arr2)
        {
            int n = arr1.Length + arr2.Length;
            int[] merged = new int[n];

            int i1 = 0, i2 = 0, m = 0;
            while (i1 < arr1.Length && i2 < arr2.Length)
            {
                if (arr1[i1] > arr2[i2])
                {
                    merged[m] = arr2[i2];
                    i2++;
                }
                else if (arr2[i2] > arr1[i1])
                {
                    merged[m] = arr1[i1];
                    i1++;
                }
                m++;
            }

            while (i1 < arr1.Length)
            {
                merged[m] = arr1[i1];
                m++;
                i1++;
            }

            while (i2 < arr2.Length)
            {
                merged[m] = arr2[i2];
                m++;
                i2++;
            }

            return merged;
        }
    }
}
