using System.Collections.Generic;
using System;

namespace KataCSharp.LeetCode.B
{
    public class JumpGame
    {

		//You are given an integer array nums.You are initially positioned 
		//at the array's first index,each element in the 
		//array represents your maximum jump length at that position.
		//Return true if you can reach the last index, or false otherwise.

		//Input: nums = [2, 3, 1, 1, 4]
		//Output: true
		//Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

		//Input: nums = [3, 2, 1, 0, 4]
		//Output: false
		//Explanation: You will always arrive at index 3 no matter what.Its maximum jump length is 0, which makes it impossible to reach the last index.

		[Theory]
		[InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
		[InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
		public void CanJumpTest(int[] nums, bool expected)
		{
			var result = CanJump(nums,0);
			Assert.Equal(expected, result);
		}		
		
		public bool CanJump(int[] nums, int idx)
		{
			var length = nums.Length-1;
			if (idx > length || nums[idx] == 0) return false;
			
			var num = nums[idx];
			if ((num+1 - length) == 0) return true;

			for (int i = 1; i <= num; i++)
			{
				return CanJump(nums, i);
			}

			return false;
		}

	}
}
