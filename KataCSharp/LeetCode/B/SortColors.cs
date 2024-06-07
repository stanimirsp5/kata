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
        [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new int[] { 7, 5, 1, 10, 8, 9 }, new int[] { 1, 5, 7, 8, 9, 10 })]
        [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
        [InlineData(new int[] { 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 2, 5, 1, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 2, 5, 1 }, new int[] { 1, 2, 5 })]
        public void SortColorsTest(int[] input, int[] result)
        {
            //var copiedInput = new int[input.Length];
            //Array.Copy(input,copiedInput,input.Length);
            //InsertionSort(input);
            QuickSort(input, 0, input.Length-1);
            Assert.Equal(result, input);

        }

        // 2, 5, 1 -> 1, 5, 2 -> 1, 2, 5
        // 2, 5, 1, 4, 3
        void QuickSort(int[] nums, int low, int high)// 0, 2
        {
            if (low < high)
            {

                int partition = GetPartition(nums, low, high);

                QuickSort(nums, low, partition);
                QuickSort(nums, partition + 1, high);
            }
        }

        private int GetPartition(int[] nums, int low, int high)// 0 ,2
        {
            int partition = nums[high];// 1
            int j = low;// 0
            for (int i = low; i <= high - 1; i++)
            {
                if(nums[i] < partition)// 2<1 f;f
                {
                    Swap(nums,i,j);// res 1,5,2
                    j++;
                }
            }

            Swap(nums, j, high);

            return j;
        }

        private void Swap(int[] nums, int fromNum, int toNum)
        {
            int temp = nums[fromNum];
            nums[fromNum] = nums[toNum];
            nums[toNum] = temp;
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
    
        void InsertionSort(int[] nums)
        {

            for (int i = 1; i < nums.Length; i++)
            {
                int currNum = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > currNum)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j+1] = currNum;
            }

        }
    }
}
