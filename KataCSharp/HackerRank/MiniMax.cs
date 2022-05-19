using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgorithmsSoftuni.HackerRank
{
   public class MiniMax
    {
        public static void miniMaxSum(List<int> unorderedArr)
        {
            long minSum = 0;
            long maxSum = 0;
            var arr = unorderedArr.OrderBy(x => x).ToList();
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == 0)
                {
                    minSum += arr[i];
                }
                else if (i == 4)
                {
                    maxSum += arr[i];
                }
                else
                {
                    minSum += arr[i];
                    maxSum += arr[i];
                }
            }

            Console.WriteLine(maxSum);
        }

    }
}
