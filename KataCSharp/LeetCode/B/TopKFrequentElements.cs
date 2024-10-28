using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
	public class TopKFrequentElements
	{
		//[1,1,1,2,2,3], k = 2 Output: [1,2] 
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

			yield return new object[] { new TestData(new int[] { 2, 4, 1, 3 }, 4), new int[] { 1, 2, 3, 4 } };
			yield return new object[] { new TestData(new int[] { 1, 1, 3, 2, 2, 1 }, 2), new int[] { 1, 2 } };
			yield return new object[] { new TestData(new int[] { 1 }, 1), new int[] { 1 } };
			yield return new object[] { new TestData(new int[] { 4, 1, -1, 2, -1, 2, 3 }, 2), new int[] {-1, 2} };
		}

		//[1,1,1,2,2,3], k = 2
		// 5, 2, 4, 1, 3
		public int[] GetTopKFrequent(int[] nums, int k)
		{
			Sort(nums, 0, nums.Length - 1);
			int[] res = GetMostFrequent(nums, k);
			return res;
		}

		private int[] GetMostFrequent(int[] nums, int k)
		{
			var dict = new Dictionary<int, int>();

			foreach (int i in nums)
			{
				if (dict.ContainsKey(i))
				{
					var value = dict[i];
					dict[i] = ++value;
				}
				else
				{
					dict.Add(i, 1);
				}
			}

			var orderedDict = dict.OrderByDescending(x => x.Value).Take(k);
			return orderedDict.Select(x => x.Key).ToArray();
		}



		private int[] GetMostFrequent2(int[] nums, int k)
		{
			var res = new List<int>();
			var end = 0;
			var j = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (end == k)
					return res.ToArray();

				if (i + 1 >= nums.Length)
				{
					res.Add(nums[i]);
					return res.ToArray();

				}
				else
				{
					j = nums[i + 1];
				}

				if (nums[i] != j)
				{
					res.Add(nums[i]);
					end++;
				}
			}
			return res.ToArray();
		}

		void Sort(int[] nums, int low, int high)
		{
			if (low < high)
			{
				int partial = GetPivot(nums, low, high);

				Sort(nums, low, partial - 1);
				Sort(nums, partial + 1, high);
			}
		}

		int GetPivot(int[] nums, int low, int high)
		{
			int pivot = nums[high];
			int j = low;
			for (int i = low; i <= high - 1; i++)
			{
				if (nums[i] < pivot)
				{
					Swap(nums, i, j);
					j++;
				}
			}
			Swap(nums, j, high);

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
