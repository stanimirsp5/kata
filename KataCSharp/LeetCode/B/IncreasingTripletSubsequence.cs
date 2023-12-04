using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
	public class IncreasingTripletSubsequence
	{
		//Given an integer array nums, return true if there exists a triple of indices (i, j, k)
		//such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.

		//Input: nums = [1,2,3,4,5]
		//Output: true
		//Explanation: Any triplet where i<j < k is valid.
		//Input: nums = [5,4,3,2,1]
		//Output: false
		//Explanation: No triplet exists.
		//Input: nums = [2,1,5,0,4,6]
		//Output: true
		//Explanation: The triplet(3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
		public void Start()
		{
			//int[] arr = new int[] { 1, 2, 3, 4, 5 }; // 6,7,1,2
			//int[] arr = new int[] { 20, 100, 10, 12, 5, 13 };
			//int[] arr = new int[] { 6, 7, 1, 2 };
			//int[] arr = new int[] { 5, 4, 3, 2, 1 };
			//int[] arr = new int[] { 20,100,10,12,5,13 };
			int[] arr = new int[] { 2, 1, 5, 0, 4, 6 };
			var res = FindTriplet(arr);
		}

		public bool FindTriplet(int[] arr)
		{
			int count = 0;
			int maxNum = arr[0];
			for (int i = 0, j = 1; j < arr.Length; i++, j++)
			{
				if (maxNum < arr[j])
				{
					maxNum = arr[j];
					count++;
				}

				if (count == 2) return true;
			}
			return false;
		}
	}
}
