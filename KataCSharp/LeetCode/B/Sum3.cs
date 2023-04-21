using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class Sum3
    {

        public void Start()
        {
            //int[] arr = new int[] { -4, 2, -1, -1 };
            //int[] arr = new int[] { -1, 0, 1, -1, 0 };
            //int[] arr = new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };
            int[] arr = new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 };
            // int[] arr = new int[] {3, 0, -2, -1, 1, 2};
            //int[] arr = new int[] {0, 3, 0, 1, 1, -1, -5, -5, 3, -3, -3, 0};
            //Triplets(arr);

            FindTriplets(arr);
        }

        public IList<IList<int>> FindTriplets(int[] nums)
        {
            List<IList<int>> tripletsResults = new List<IList<int>>();

            for (int row1 = 0; row1 < nums.Length; row1++)
            {
                List<IList<int>> triplets = GetTripletArray(nums, row1).ToList();

                foreach (var triplet in triplets)
                {
                    if (AreTripletsUnique(triplet, tripletsResults))
                    {
                        tripletsResults.Add(triplet);
                    }
                }
            }
            return tripletsResults;
        }

        private List<IList<int>> GetTripletArray(int[] nums, int row1)
        {
            int n = nums.Length;
            List<IList<int>> tempTriplets = new List<IList<int>>();

            int num1 = nums[row1];
            for (int row2 = 0; row2 < n; row2++)
            {
                int num2 = nums[row2];
                if (row1 == row2)
                    continue;

                for (int row3 = 0; row3 < n; row3++)
                {
                    int num3 = nums[row3];
                    if (row3 == row2 || row3 == row1)
                        continue;

                    if (num1 + num2 + num3 == 0)
                    {
                        tempTriplets.Add(new List<int> { num1, num2, num3 });

                    }
                }
            }
            return tempTriplets;
        }

        private bool AreTripletsUnique(IList<int> triplets, List<IList<int>> tripletsResults)
        {
            foreach (var tripletsResult in tripletsResults)
            {
                var isContainSameDigits1 = triplets.Except(tripletsResult);
                var isContainSameDigits2 = tripletsResult.Except(triplets);

                if (!isContainSameDigits1.Any() && !isContainSameDigits2.Any())
                {
                    return false;
                }
            }
            return true;
        }
        public IList<IList<int>> FindTriplets3(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> tripletsResults = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        tripletsResults.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1])
                            left++;
                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return tripletsResults;
        }
        //private bool AreTripletsUnique(IList<int> triplets, List<IList<int>> tripletsResults)
        //{
        //    foreach (var tripletsResult in tripletsResults)
        //    {
        //        if (Enumerable.SequenceEqual(triplets, tripletsResult))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        // [[-2,-1,3],[-2,0,2],[-1,0,1]]
        public IList<IList<int>> Triplets2(int[] arr)
        {
            int n = arr.Length;
            var matrix = new List<IList<int>>();
            var list = new List<int>();
            int fir = 0, sec = 1, trd = 2;
            int t = 0, s = 0;
            if (sec == n || trd == n) return matrix;

            while (fir < n)
            {
                if (t == n)
                {
                    t = 0;
                    sec++;
                    s++;
                }

                if (sec == n) sec = 0;
                if (trd == n) trd = 0;
                if (trd == fir || trd == sec)
                {
                    trd++;
                    t++;
                    continue;
                }
                if (sec == fir)
                {
                    sec++;
                    s++;
                    continue;
                }

                int num1 = arr[fir];
                int num2 = arr[sec];
                int num3 = arr[trd];

                if (num1 + num2 + num3 == 0)
                {
                    list = new List<int> { num1, num2, num3 };
                    list.Sort();
                    if (!matrix.Any(m => Enumerable.SequenceEqual(m, list)))
                    {
                        matrix.Add(list);
                    }
                }
                if (s >= n)
                {
                    s = 0;
                    fir++;
                }
                trd++;
                t++;
            }

            return matrix;
        }
        public List<IList<int>> Triplets(int[] arr)
        {
            int n = arr.Length;
            var matrix = new List<IList<int>>();
            for (int fir = 0; fir < n; fir++)
            {
                for (int sec = fir + 1, j = 0; j < n; sec++, j++)
                {
                    if (sec == n) sec = 0;
                    if (sec == fir) continue;

                    for (int trd = sec + 1, k = 0; k < n; trd++, k++)
                    {
                        if (trd == n) trd = 0;
                        if (trd == fir || trd == sec) continue;
                        if (arr[fir] + arr[sec] + arr[trd] == 0)
                        {
                            var sortedList = new List<int> { arr[fir], arr[sec], arr[trd] };
                            sortedList.Sort();

                            matrix.Add(sortedList);
                        }

                    }
                }
            }
            var res = new List<IList<int>>();

            foreach (var item in matrix)
            {
                if (!res.Any(els => Enumerable.SequenceEqual(item, els)))
                {
                    res.Add(item);
                }
            }


            return res;
        }


    }
}
