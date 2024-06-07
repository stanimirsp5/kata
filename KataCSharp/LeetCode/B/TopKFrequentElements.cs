using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    public class TopKFrequentElements
    {
        //[1,1,1,2,2,3], k = 2
        public record TestData(int[] nums, int k);
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TopKFrequentTest(TestData testData, int[] result)
        {
            var res = GetTopKFrequent(testData.nums, testData.k);

            Assert.Equal(result, res);
        }
        public static IEnumerable<object[]> GetTestData()
        {

            yield return new object[] { new TestData(new int[] { 2, 4, 1, 3 }, 2), new int[] { 1, 2, 3, 4 } };
            //yield return new object[] { new TestData(new int[] { 1, 1, 1, 2, 2, 3 }, 2), new int[] { 1, 2 } };
        }

        //[1,1,1,2,2,3], k = 2
        // 5, 2, 4, 1, 3
        public int[] GetTopKFrequent(int[] nums, int k)
        {
            Sort(nums, 0, nums.Length);
            return nums;
        }

        void Sort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int partial = GetPivot(nums, low, high);

                Sort(nums, 0, partial);
                Sort(nums, partial, high);
            }
        }

        int GetPivot(int[] nums, int low, int high)
        {
            Console.WriteLine(high - 1);
            int pivot = nums[high - 1];
            int j = low;
            for (int i = 0; i < high; i++)
            {
                if (nums[i] < pivot)
                {
                    Swap(nums, i, j);
                    j++;
                }
            }
            Swap(nums, high - 1, j);

            return j;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
