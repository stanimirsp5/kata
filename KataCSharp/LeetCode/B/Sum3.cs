using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class Sum3
    {
        public void MyMain()
        {
            //int[] arr = new int[] {-1, 0, 1, 2, -1, -4 };
            int[] arr = new int[] {3, 0, -2, -1, 1, 2};
            //int[] arr = new int[] {0, 3, 0, 1, 1, -1, -5, -5, 3, -3, -3, 0};
            Triplets(arr);
        }
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
                if(trd == fir || trd == sec)
                {
                    trd++;
                    t++;
                    continue;
                }
                if(sec == fir)
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
                    fir++; }
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
