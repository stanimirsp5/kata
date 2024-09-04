using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Algorithms.Sorting
{
	public class Quicksort
	{
		[Theory]
		[MemberData(nameof(GetTestData))]
		void TestSort(TestData testData)
		{
			var arr = testData.input;
			IEnumerable<int> res = Sort(arr, 0, arr.Length-1);

			Assert.Equal(res, testData.result);

		}

		public record TestData(int[] input, int[] result);
		public static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new TestData(new int[] { 3, 2, 4, 1, 5 }, new int[] { 1, 2, 3, 4, 5 }) };
			//yield return new object[] { new TestData(new int[] { 4, 2, 1, 6, 5, 3 }, new int[] { 1, 2, 3, 4, 5, 6 }) };
		}

		// 10,80,30,90,40; p-40
		// 10,30,80,90,40 -> 10,30,40,80,90
		// 10,30,80,90,40 -> 10,30,40,90,80

		// 11, 9, 12, 7, 3^
		// 3, 9, 12, 7, 11^ -> 3,9,7,12,11^ -> 3,9,7,11,12

		//3,2,4,1,5 s-0 e-4
		private IEnumerable<int> Sort(int[] input, int start, int end)
		{
			if (start <= end)
			{
				var partition = GetPartition(input, start, end);


				Sort(input, start, partition - 1);
				Sort(input, partition+1, end);
			}
            return input;
		}

		// 3,5,4,1,2
		// 3,2,4,1,5 -> 3,2,4,1,5^ -> 3,2,4,1^,5 -> 1,2,4,3,5 -> 1,2^,4,3,5 -> 1^,2,4,3,5  ->  1,2,4,3,5 
		private int GetPartition(int[] input, int start, int end)
		{
			//get parition
			var partition = input[end];
			var j = start;

            for (int i = start; i < end; i++)
            {
				var currNum = input[i];
				if (currNum < partition)
				{
					Swap(input, i, j);
					j++;
				}
            }

			Swap(input, end, j);


			return end;
		}

		private void Swap(int[] input, int i, int j)
		{
			var temp = input[i];
			input[i] = input[j];
			input[j] = temp;
		}

	}
}
