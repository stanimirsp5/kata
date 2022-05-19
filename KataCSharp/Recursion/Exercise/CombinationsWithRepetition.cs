using System;
using System.Collections.Generic;

namespace AlgorithmsSoftuni.Recursion.Exercise
{
    public class CombinationsWithRepetition
    {
        //static void Main(string[] args)
        //{
        //    int n =Int32.Parse(Console.ReadLine());
        //    int k = Int32.Parse(Console.ReadLine());

        //    Recur(n, k);
        //}
        public static void Recur(int n, int k)// n - number of elements, k - array length
        {
            var arr = new int[k];
            Combinate(n,arr);

        }
        private static void Combinate(int n, int[] arr, int index = 0, int element = 1)
        {

            if (arr.Length == index)
            {
                Console.WriteLine(String.Join(" ", arr));

                return;
            }
            for (int i = element; i <= n; i++)
            {
                arr[index] = i;
                Combinate(n,arr,index+1,i);
            }

        }
        //private static void Combinate(int n, int[] arr, int index = 0, int element = 1)
        //{
        //    if (index == arr.Length)
        //    {
        //        Console.WriteLine(String.Join(" ", arr));
        //        return;
        //    }


        //    for (int i = element; i <= n; i++)
        //    {
        //        arr[index] = i;
        //        Combinate(n, arr, index + 1, i);
        //    }
        //}

        public static void Generate(int[] arr, int[] vector, int index, int border)
        {
            if (vector.Length == index)
            {
                Console.WriteLine(String.Join("", vector));
            }
            else
            {
                for (int i = border; i < arr.Length; i++)
                {
                    vector[index] = arr[i];
                    Generate(arr, vector, index + 1, i + 1);
                }

            }
        }

        //private static void Combinate(int n, List<string> arr, int p)
        //{
        //    if (p > n) return;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        arr.Add(p + "" + i);
        //        Console.WriteLine(p + " " + i);
        //        //if (!arr.Contains(i + "" + p))
        //        //{
        //        //    Console.WriteLine(p + " " + i);
        //        //}
        //        //if(i == p)
        //        //{
        //        //    Console.WriteLine(p + " " + i);

        //        //}
        //    }
        //    Combinate(n, arr, p + 1);
        //}
       
    }
}
