using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.HackerRank
{
    internal class RotateNumbers
    {
        //{ 12, 13, 8, 5 },
        //{ 14, 3, 8, 1 },
        //{ 12, 3, 8, 1 },
        //{ 5, 5, 8, 5}};
        public void RotateImage(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            var replasedNumsDict = new Dictionary<string, int>();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = matrix[row,col];

                    int numToBeReplaced = matrix[col,n - 1 - row];
                    string originalKeyInMatrix = "row"+row.ToString() + "col"+col;
                    string keyNumberToReplace = "row" + col.ToString() + "col" + ((n - 1) - row);
                    if (replasedNumsDict.TryGetValue(originalKeyInMatrix, out int val))
                    {
                        num = val;
                        // replasedNumsDict.TryGetValue(originalKeyInMatrix, out num);
                        replasedNumsDict.Remove(originalKeyInMatrix);
                        replasedNumsDict.Add(keyNumberToReplace, numToBeReplaced);
                    }
                    else
                    {

                        replasedNumsDict.Add(keyNumberToReplace, numToBeReplaced);
                    }
                    matrix[col,n - 1 - row] = num;
                }
            }

            //return matrix;
        }
        //[1,2,3,4,5,6,7], k = 3
        public static void Rotate(int[] nums, int k)
        {
            if(k == 0 || nums.Length <=1) return;

            int n = nums.Length;//7
            k = k % n;//3
            Reverse(nums, 0, n-1 - k);// 0 1
            Reverse(nums, n - k, n-1);// 3 - 3
            Reverse(nums, 0, n-1);
        }
        public static void Reverse(int[] arr, int start, int end)
        {

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        public bool HashtableDemo(int[] nums)
        {
            int n = nums.Length;

             var dict = new Dictionary<int, int>();
            dict[123] = 1232;
            dict[123] = 21232;
            dict.Add(1234, 1332);
            for (int i = 0; i < n; i++)
            {
                if (dict[nums[i]] != null)
                {
                    return true;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            n.ToString();
            return false;

        }
        public int SingleNumber(int[] nums)
        {

            int n = nums.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict.Remove(nums[i]);
                }
                else
                {

                    dict[nums[i]] = nums[i];
                }
            }

            return dict.FirstOrDefault().Value;

        }
        public int SingleNumberXOR(int[] nums)
        {
            if (nums == null)
                return -1;

            int sum = 0;
            foreach (var item in nums)
            {
                sum ^= item;
            }

            return sum;
        }
        //public static int[] Rotate(int[] nums, int k)
        //{
        //    // [1,2,3,4,5,6,7] k = 3, l = 7
        //    int n = nums.Length;
        //    int[] rotatedNums = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        rotatedNums[CalculateIndex(k, i, n)] = nums[i];
        //    }
        //    return rotatedNums;
        //}
        //public static int CalculateIndex(int k, int i, int n)
        //{
        //    int j = k + i;
        //    if (j < n) return k;

        //    return CalculateIndex(Math.Abs(n - j), i, n);

        //}



    }
}
