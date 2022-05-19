using System;
namespace AlgorithmsSoftuni.Recursion
{
    public class GeneratingCombinations
    {

        public void Generate(int[] arr, int[] vector, int index, int border)
        {
            if(vector.Length == index)
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

        //public void Generate(int[] arr, int[] vector, int index, int border)
        //{

        //    if (vector.Length == index)
        //    {
        //        Console.WriteLine(String.Join("", vector));
        //    }
        //    else
        //    {

        //        for (int i = border; i < arr.Length; i++)
        //        {
        //            vector[index] = arr[i];
        //            Generate(arr, vector, index + 1, i + 1);
        //        }

        //    }
        //}

        //public void Generate( int[] set, int[] vector, int index,int border) {

        //    if(index == vector.Length)
        //    {
        //        Console.WriteLine(String.Join("", vector));
        //    }
        //    else
        //    {
        //        for (int i = border; i < set.Length; i++)
        //        {
        //            vector[index] = set[i];
        //            Generate(set, vector, index + 1, i + 1);
        //        }
        //    }

        //}

    }
}
