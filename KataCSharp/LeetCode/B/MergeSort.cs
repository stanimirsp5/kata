using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class MergeSort
    {

        public void MyMain()
        {
            // int[] arr = new int[] { 7,3,4,9,6,5,2,8,1 };

            int[] arr = new int[] { 5, 2 };
            int[] arr88 = new int[] { 5, 4, 1, 3, 2 };
            int[] arr2 = new int[] { 6,5,7,1};
            Sort(arr2, 0, arr2.Length-1);
            //int[] arr = new int[] { 3, 4, 5, 1, 2 };
           // Merge(arr,0, 0, arr.Length-1);
        }

        public void Test()
        {
            int t = 34;
            Del handler = DelegateMethod;
            handler("delegate call");
        }

        public static void DelegateMethod(string msg)
        {
            Console.WriteLine(msg);
        }

        public delegate void Del(string msg);

        public void Sort(int[] arr, int lo, int hi)// 0, 3;2,3;
        {
            if (lo >= hi) return;

            int mid = lo + (hi - lo) / 2;//1,2
            Sort(arr, lo, mid);//2,2
            Sort(arr, mid + 1, hi);//2,3,3,3

            Merge(arr, lo, mid, hi);//0,0,1;2,2,3;0,2,3
            
        }

        public void Merge(int[] arr, int lo, int mid, int hi)//
        {

            int[] arr1 = new int[mid-lo+1];
            int[] arr2 = new int[hi-mid];
            for (int i = 0, iarr = lo; i < arr1.Length; i++, iarr++)
            {
                arr1[i] = arr[iarr];
            }

            for (int j = 0,jarr=mid+1; j < arr2.Length; j++, jarr++)
            {
                arr2[j] = arr[jarr];
            }

            int k = lo, k1 = 0, k2 = 0;
            while (k1 < arr1.Length && k2 < arr2.Length)
            {
                if (arr1[k1] > arr2[k2])
                {
                    arr[k] = arr2[k2];
                    k++;k2++;
                }
                else if (arr2[k2] > arr1[k1])
                {
                    arr[k] = arr1[k1];
                    k++;k1++;
                }
            }

            while(k1 < arr1.Length)
            {
                arr[k] = arr1[k1];
                k++;
                k1++;
            }

            while(k2 < arr2.Length)
            {
                arr[k] = arr2[k2];
                k++;
                k2++;
            }


        }

        public void Merge2(int[] arr, int lo, int mid, int hi)//0,1,3
        {
            int n1 = mid - lo + 1;
            int n2 = hi - mid;
            int[] arr1 = new int[n1];
            int[] arr2 = new int[n2];

            int i = 0, k = 0;
            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[lo+i];
            }
            for (k = 0; k < arr2.Length; k++)
            {
                //arr2[i] = arr[n2+i];
                arr2[k] = arr[mid+1+k];
            }

            i = 0;k = 0;

            int j = lo;

            while(i<n1 && k < n2) {
                if (arr1[i] <= arr2[k])
                {
                    arr[j] = arr1[i];
                    i++;
                }
                else
                {
                    arr[j] = arr2[k];
                    k++;
                }
                j++;
            }

            while(i < n1)
            {
                arr[j] = arr1[i];
                i++;j++;
            }
            while (j < n2)
            {
                arr[j] = arr2[k];
                k++;j++;
            }

        }

        //public void Merge(int[] arr, int lo, int mid, int hi)//0,1,3
        //{
        //    int i = lo, j = mid;

        //    while (i < mid && j < hi)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            Swap(arr, i, j);
        //        }
        //        i++; j++;
        //    }
        //    //first arr
        //    int k = mid;
        //    while (i < mid+1)
        //    {
        //        if (arr[i] > arr[k])
        //        {
        //            Swap(arr, i, k);
        //        }
        //        i++;
        //    }

        //    //while (j < hi)
        //    //{
        //    //    if (arr[j] > arr[])
        //    //}
        //}

        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


    }
}
