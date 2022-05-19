using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeetCode
{
    internal class TwoSum
    {
        public int[]? AddTwoSum()
        {
            int[] nums = new int[] {4,7,5,2,3,5};
            int target = 8;
            Dictionary<int, int> dict = nums.Select((num, idx) => new { num, idx }).ToDictionary(el => el.idx, el => el.num);
            int difference = 0;
           
            foreach (KeyValuePair<int,int> kvp in dict)
            {

                difference = target - kvp.Value;
                var kvpDifferenceNum = dict.FirstOrDefault(d => d.Value == difference && kvp.Key != d.Key);
                if (!kvpDifferenceNum.Equals(default(KeyValuePair<int,int>)))
                {

                    return new int[] { kvp.Key, kvpDifferenceNum.Key };
                }

            }
            return null;
        }
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                var lookup = board[i].ToList().ToLookup(el => GetQuadrant(i), el => el);
                //lookup.Contains();
                for (int k = 0; k < board.Length; k++)
                {
                    // check for row

                    // check for col

                    // chack for 3x3 square

                }
            }
            return true;
        }
        private int GetQuadrant(int i)
        {
            if(i <= 3)
            {
                return 1;
            }else if (i<=6)
            {
                return 2;
            }
            else { return 3; }
        }
    }
}
