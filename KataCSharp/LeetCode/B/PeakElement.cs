using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
	//nums = [1,2,3,1] output 2
	//nums = [1,2,1,3,5,6,4] output 2 or 5
	//You must write an algorithm that runs in O(log n) time.
	public class PeakElement
	{

		[Theory]
		[MemberData(nameof(GetTestData))]
		public void PeakElementTest(int[] nums, int expectedIndex)
		{
			//int res = FindPeakNum(nums);
			int res = FindPeakNumBinarySearch(nums);

			Assert.Equal(expectedIndex, res);
		}

		private int FindPeakNum(int[] nums)
		{
			if (nums.Length == 2) return nums[0] > nums[1] ? 0 : 1;
			if (nums.Length > 2 && nums[0] > nums[1]) return 0;

			for (int i = 1; i < nums.Length - 1; i++)
			{
				var currNum = nums[i];
				var prevNum = nums[i - 1];
				var nextNum = nums[i + 1];
				if (currNum > prevNum && currNum > nextNum)
					return i;
			}

			if (nums.Length > 2 && nums[nums.Length - 1] > nums[nums.Length - 2])
				return nums.Length - 1;

			return 0;
		}

		// 1, 2, 3, 1 
		// .  .	 LM R
		private int FindPeakNumBinarySearch(int[] nums)
		{
			var right = nums.Length - 1;
			var left = 0;

			while (left < right)
			{
				var mid = (left + right) / 2;
				if (nums[mid+1] > nums[mid])
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
			}

			return left;
		}


		public static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new int[] { 1, 2, 3, 1 }, 2 };
			yield return new object[] { new int[] { 4, 3, 2, 1 }, 0 };
			yield return new object[] { new int[] { 1, 2 }, 1 };
			yield return new object[] { new int[] { 1 }, 0 };
			yield return new object[] { new int[] { 2, 1 }, 0 };
			yield return new object[] { new int[] { 1, 2, 3 }, 2 };
			yield return new object[] { new int[] { 1, 2, 3, 4 }, 3 };
			yield return new object[] { new int[] { 3, 2, 1 }, 0 };
			yield return new object[] { new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5 };

		}
	}
}
