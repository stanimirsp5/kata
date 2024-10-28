
using System.Diagnostics.CodeAnalysis;

namespace KataCSharp.LeetCode.B
{
	public class KLargestElement
	{
		public record TestData(int[] nums, int k);

		[Theory]
		[MemberData(nameof(GetTestData))]
		public void KLargestElementTest(TestData testData, int result)
		{
			//var t = new int[] { 3, 2, 1, 5, 6, 4 };
			//Sort(t);
			//var largestNum = GetKLargestElement(testData.nums, testData.k);
			var largestNum = GetKLargestUsingSortedDictionary(testData.nums, testData.k);

			Assert.Equal(largestNum, result);
		}

		public static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new TestData(new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 };
			yield return new object[] { new TestData(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 };
		}


		public int GetKLargestUsingSortedDictionary(int[] nums, int k)
		{
			var sd = new SortedDictionary<int, int>(new Comparer<int>());
			foreach (int num in nums)
				if (sd.ContainsKey(num))
					sd[num] = ++sd[num];
				else
					sd.Add(num,1);

            foreach (var el in sd)
            {
				k -= el.Value;
                if(k <= 0)
					return el.Key;
            }
            return 0;
		}

		//TODO check with pq
		public int FindKthLargestPriorityQueue(int[] nums, int k)
		{
			PriorityQueue<int, int> pq = new PriorityQueue<int, int>(nums.Length);

			foreach (int num in nums)
			{
				pq.Enqueue(num, -num);
			}

			int ret = -1;
			for (int i = 0; i < k; i++)
			{
				ret = pq.Dequeue();
			}


			return ret;
		}

		public class Comparer<T> : IComparer<int>
		{
			public int Compare(int x, int y)
			{
				return y - x;
			}
		}


		public int GetKLargestElement(int[] nums, int k)
		{
			var n = nums.Length;
			//if (n < 100)
			//	Sort(nums);
			//else
			QSort(nums, 0, n - 1);

			var kLargestNum = nums[nums.Length - k];
			return kLargestNum;
		}

		//2,3,1,4 
		void Sort(int[] nums)
		{

			for (int i = 1; i < nums.Length; i++)
			{
				int j = i - 1;
				var currNum = nums[i];
				while (j >= 0 && currNum < nums[j])
				{
					nums[j + 1] = nums[j];
					j--;
				}
				nums[j + 1] = currNum;

			}
		}

		//3, 2, 1, 5, 6, 4^ -> 3, 2, 1, 4, 6, 5 -> 3, 2, 1^, 4, 6, 5 -> 1, 2, 3, 4, 6, 5^ -> 1, 2, 3, 4, 5, 6
		//n=8
		// 3, 2, 3, 1, 2, 4, 5, 5, 6
		void QSort(int[] nums, int start, int end)
		{
			if (start < end)
			{
				int partition = GetPartition(nums, start, end);

				QSort(nums, start, partition - 1);
				QSort(nums, partition + 1, end);
			}
		}

		private int GetPartition(int[] nums, int start, int end)
		{
			int partition = nums[end];
			int j = start - 1;//secondPointer
			for (int i = start; i <= end - 1; i++)
			{
				if (nums[i] < partition)
				{
					j++;
					Swap(nums, i, j);
				}
				//nums[j] = nums[end];
			}
			Swap(nums, j + 1, end);
			return j + 1;
		}



		void Swap(int[] nums, int i, int j)
		{
			var temp = nums[i];
			nums[i] = nums[j];
			nums[j] = temp;
		}

	}
}

// 3, 2, 3, 1, 2, 4, 5, 5, 6^