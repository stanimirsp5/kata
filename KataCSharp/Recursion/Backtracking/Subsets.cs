using System;
using System.Collections;
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
       
        List<IList<int>> endRes = new List<IList<int>>();

        public void Start()
        {
            
            int[] arr = new int[] { 1, 2, 3 };

            //Subset(arr);
            //Cascading(arr);
            SubsetBack(arr);
        }

        public IList<IList<int>> Subset(int[] nums)
        {
            int n = 0;
            int[] res = new int[n];

            for (int i = 0; i <= nums.Length; i++)
            {
                n = i;
                res = new int[n];
                Combination(0, 0, n, res, nums);
            }
            return endRes;
        }

        void Combination(int index, int start, int n, int[] res, int[] nums)
        {
            if(index >= n)
            {
                endRes.Add(res.ToList());
                return;
            }
            
            for (int i = start; i < nums.Length; i++)
            {

                res[index] = nums[i];
                Combination(index + 1, i+1,n,res,nums);

            }

        }

        // iterative approach
        List<IList<int>> Cascading(int[] arr)
        {
            List<IList<int>> outputs = new List<IList<int>>();
            outputs.Add(new List<int>());

            foreach (var num in arr)
            {
                List<List<int>> temp = new List<List<int>>();

                foreach (var output in outputs)
                {

                    temp.Add(new List<int>(output) { { num } });

                }

                foreach (var item in temp)
                {
                    outputs.Add(item);
                }

            }
            return outputs;
        }

        List<IList<int>> outBack = new List<IList<int>>();
        int kb;
        public IList<IList<int>> SubsetBack(int[] nums)
        {
            for (int i = 0; i <= nums.Length; i++)
            {
                kb = i;
                Backtrack(0, new List<int>(), nums);
            }
            return outBack;
        }

        void Backtrack(int first, List<int> curr, int[] nums)
        {
            if(curr.Count == kb)
            {
                outBack.Add(new List<int>(curr));
                return;
            }

            for (int i = first; i < nums.Length; i++)
            {
                curr.Add(nums[i]);
                Backtrack(i+1, curr, nums);
                curr.RemoveAt(curr.Count - 1);
            }

        }

    }
}
