using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace KataCSharp.LeetCode.B
{
	//There is an integer array nums sorted in ascending order(with distinct values).

	//Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k(1 <= k<nums.length) such that the resulting array is [nums[k],
	//nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0-indexed). For example, [0, 1, 2, 4, 5, 6, 7] might be rotated at pivot index 3 and
	//become[4, 5, 6, 7, 0, 1, 2].

	//Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

	//You must write an algorithm with O(log n) runtime complexity.



	//Example 1:
	//Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 0
	//Output: 4

	//Example 2:
	//Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 3
	//Output: -1

	//Example 3:
	//Input: nums = [1], target = 0
	//Output: -1

	public class SearchInRotatedSortedArray
	{

		[Theory]
		[InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
		[InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
		[InlineData(new int[] { 1 }, 0, -1)]
		public void TestSearchInRotatedSortedArray(int[] nums, int target, int expected)
		{
			var result = Search(nums, target);
			Assert.Equal(expected, result);
		}

		public int Search(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == target)
				{
					return i;
				}
			}
			return -1;
		}

		// [4, 5, 6, 7, 0, 1, 2] s-0 e-6
		public int BSearch(int[] nums, int target, int start, int end)
		{
			if(start > end)
			{
				return -1;
			}

			int mid = (start + end) / 2;

			return 0;
		}

	}
}
