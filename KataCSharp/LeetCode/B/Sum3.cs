using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class Sum3
    {
        public void MyMain()
        {
            //int[] arr = new int[] {-1, 0, 1, 2, -1, -4};
            int[] arr = new int[] {0, 3, 0, 1, 1, -1, -5, -5, 3, -3, -3, 0};
            Triplets(arr);
        }

        public IList<IList<int>> Triplets(int[] arr)
        {
            int n = arr.Length;
            var matrix = new List<IList<int>>();
            var set = new HashSet<List<int>>();
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
                            //if (IsMatrixUnique(matrix, arr[fir], arr[sec], arr[trd]))
                            //{
                            //    matrix.Add(new List<int> { arr[fir], arr[sec], arr[trd] });
                            //}
                            var sortedList = new List<int> { arr[fir], arr[sec], arr[trd] };
                            sortedList.Sort();
                            matrix.Add(sortedList);
                        }

                    }
                }
            }
            matrix = matrix.Distinct().ToList();
            return matrix;
        }

        public bool IsMatrixUnique(List<IList<int>> matrix, int num1, int num2, int num3)
        {
            bool[] marks = new bool[3];
            var nums = new List<int> { num1, num2, num3 };
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (nums.Contains(matrix[i][j]))
                    {
                        var numToRemove = matrix[i][j];
                        int index = nums.IndexOf(numToRemove);
                        marks[j] = true;
                        nums.RemoveAt(index);
                    }
                }
                if(!marks.Any(el => el == false)){ return false; }
                marks = new bool[3];
                nums = new List<int> { num1, num2, num3 };
            }


            return marks.Any(el => el == false);
        }

    }
}
