using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Recursion.Backtracking
{
    //  Input: nums = [1,2,3]
    //  Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
    internal class Subsets
    {
        int[] arr = new int[] { 1, 2, 3 };
        static int n = 2;
        int[] res = new int[n];
       
        public void Start()
        {
            Combination(0,0);
        } 

        void Combination(int index, int start)
        {
            if(index >= n)
            {
                Common.PrintArray(res);
                return;
            }

            for (int i = start; i < arr.Length; i++)
            {

                res[index] = arr[i];
                Combination(index + 1, i+1);

            }

        }

    }
}
