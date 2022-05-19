using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSoftuni.CodingGames
{
    internal class NumberOfItems
    {
        static void Main(string[] args)
        { 
            int[] nums = new int[5] { 0, 1, 0, 2, 1 };
            var list = new List<int>(nums);
           var t = NumbersCount(list);
        }
        public static List<int> NumbersCount(List<int> nums)
        {
           // List<int> counters = new List<int> ( nums.Count);
            int[] counters = new int[100];
            for (int i = 0; i < nums.Count; i++)
            {
                counters[nums[i]]++;
            }
            return counters.ToList();
        }
    }
}
