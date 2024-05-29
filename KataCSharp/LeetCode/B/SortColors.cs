using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    public class SortColors
    {
        //Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent,
        //with the colors in the order red, white, and blue.
        //We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
        //You must solve this problem without using the library's sort function.
        [Theory]
        [InlineData(new int[] {2, 0, 2, 1, 1, 0}, new int[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
        [InlineData(new int[] { 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4 })]
        public void SortColorsTest(int[] input, int[] result)
        {
            //var copiedInput = new int[input.Length];
            //Array.Copy(input,copiedInput,input.Length);
            Sort(input);
            Assert.Equal(result, input);

        }

        //2, 0, 2, 1, 1, 0
        // 3, 2, 1, 5, 4, 0
        // 2,3,4,1
        public void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];

                if(i > 0 && currNum < nums[i - 1])
                {
                    SwapElements(nums,i);
                }
            }
        }

        private void SwapElements(int[] nums, int n)
        {
            int currNum = nums[n];
            for (int i = 0; i <= n; i++)
            {
                int temp = nums[i];
                if(currNum < temp)
                {
                    nums[i] = currNum;
                    currNum = temp;
                }
                if (i == n)
                {
                    nums[n] = currNum;
                }
            }
        }
    }
}
