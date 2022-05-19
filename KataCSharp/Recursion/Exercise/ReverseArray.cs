using System;
namespace AlgorithmsSoftuni.Recursion.Exercise
{
    public class ReverseArray
    {
        //static void Main(string[] args)
        //{

        //    //int[] arr = { 1, 2, 3, 4, 5 };

        //    string foo = Console.ReadLine();
        //    string[] tokens = foo.Split(' ');
        //    int[] nums = new int[tokens.Length];

        //    for (int i = 0; i < tokens.Length; i++)
        //    {
        //        nums[i] = Int32.Parse(tokens[i]);
        //    }
        //    ReverseArray.Reverse(nums);
        //}
        public static void Reverse(int[] arr)
        {
            //Reverse(arr, new int[arr.Length], 0);
            ReverseLoop(arr);
        }

        private static void Reverse(int[] arr,int[] reversedArray, int index)
        {
            if(index == arr.Length)
            {
                PrintSolution(reversedArray);
            }
            else
            {
                reversedArray[index] = arr[(arr.Length-1) - index];
                Reverse(arr, reversedArray, index + 1);
            }
        }

        private static void ReverseLoop(int[] arr) {
            int[] reversedArray = new int[arr.Length];
            for (int i = arr.Length-1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] = arr[i];
            }
            PrintSolution(reversedArray);

        }

        private static void PrintSolution(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


    }
}
