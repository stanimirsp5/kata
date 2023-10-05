using KataCSharp.Common;
using System;

namespace KataCSharp.Recursion.Backtracking
{
    public class SubsetSum
    {
        static int[] arr2 = new int[] { 1, 2, 3 };
        static int[] arr = new int[] { 2, 9, 10, 1, 2, 3 };
        int m = 4;
        int[] board = new int[arr.Length];

        public void Start()
        {
            Subset(0,0);
        }

        public void Subset(int num, int index)
        {
            if(num == m)
            {
                CommonMethods.PrintArray(board);
            }
            if (num > m) return;

            for (int i = index; i < arr.Length; i++)
            {

                if(num < m)
                {
                    board[i] = 1;
                    Subset(num+arr[i],i+1);
                }
                board[i] = 0;
            }
        }



    }
}

