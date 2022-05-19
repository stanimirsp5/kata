using System;
namespace AlgorithmsSoftuni.Recursion
{
    public class Generating01Vectors
    {

        public void Generate(int[] arr, int index)
        {
            
            if(arr.Length == index)
            {
                Console.WriteLine(String.Join("",arr));
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[index] = i;
                Generate(arr, index+1);
            }

        }
        // 0000000
        // 0000001
        //public void Generate(int[] arr, int index)
        //{
        //    if (arr.Length == index)
        //    {
        //        Console.WriteLine(String.Join("", arr));
        //        return;
        //    }
        //    else
        //    {
        //        for (int i = 0; i <= 1; i++)
        //        {
        //            arr[index] = i;
        //            Generate(arr, index+1);

        //        }
        //    }
        //}

        //public void Generate(int[] arr, int index)
        //{
        //    if (arr.Length == index)
        //    {
        //        Console.WriteLine(string.Join(" ", arr));
        //        return;
        //    }
        //    else
        //    {

        //        for (int i = 0; i <= 1; i++)
        //        {
        //            arr[index] = i;
        //            Generate(arr, index+1);
        //        }

        //    }

        //}
    }
}
