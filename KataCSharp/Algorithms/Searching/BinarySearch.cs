using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Algorithms.Searching
{
	public class BinarySearch
	{
		[Theory]
		[MemberData(nameof(GetTestData))]
		public void SearchTest(int[] nums, int expectedIndex, int num)
		{
			//int res = FindPeakNum(nums);
			int res = Search(nums, num);

			Assert.Equal(expectedIndex, res);
		}
		// 1, 2, 3, 4, 5, 6  n-5
		// L     M        R
		private int Search(int[] nums, int num)
		{
			var left = 0;
			var right = nums.Length - 1;

			while (left < right)
			{
				var mid = (left + right) / 2;
				if (nums[mid] == num) return mid;
				else if (nums[mid] > num)
					right = mid;
				else
					left = mid;
			}
			return -1;
		}

		public static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new int[] { -1, 0, 3, 5, 9, 12 }, 4, 9 };
			yield return new object[] { new int[] { -1, 0, 3, 5, 9, 12 }, -1, 2 };
			yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6 }, 4, 5 };
			yield return new object[] { new int[] { 1, 2, 3, 7, 10, 11, 12, 13, 14, 15, 50, 100 }, 9, 15 };

		}

	}
}
