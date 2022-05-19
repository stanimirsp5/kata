using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSoftuni.CodingGames
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var list2 = new List<int>();
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            var list3 = new List<int>();
            list3.Add(9);
            list3.Add(8);
            list3.Add(9);

            var list2d = new List<List<int>>();
            list2d.Add(list);
            list2d.Add(list2);
            list2d.Add(list3);
            Difference(list2d);
        }
        public static int Difference(List<List<int>> arr)
        {
            int leftIndex = 0;
            int rightIndex = arr.Count-1;
            int result = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                result += arr[i][leftIndex] - arr[i][rightIndex];
                rightIndex--;
                leftIndex++;
            }

            return Math.Abs(result);

        }
        //
        //public static int Difference(List<List<int>> arr)
        //{
        //    int leftDiagonal = 0;
        //    int rightDiagonal = 0;

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        for (int j = 0; j < arr.Count;j++)
        //        {
        //            leftDiagonal += arr[i][j];
        //            i++;
        //        }
        //    }

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        for (int j = arr.Count-1; j >= 0; j--)
        //        {
        //            rightDiagonal += arr[i][j];
        //            i++;
        //        }
        //    }

        //    int result = Math.Abs(leftDiagonal - rightDiagonal);

        //    return result;
        //}

    }
}
