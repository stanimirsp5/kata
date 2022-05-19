using System;
namespace AlgorithmsSoftuni.Recursion.Exercise
{
    public class NestedLoopToRecursion
    {
        //static void Main(string[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    NestedLoopToRecursion.Recur(n);
        //}
        public static void Recur(int n)
        {
            int[] arr = new int[n];
            Recur(0, arr);
        }
        public static void Recur(int index, int[] arr)
        {
            if(arr.Length == index)
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[index] = i+1;
                Recur(index + 1, arr);

            }
        }
    }
}
