using KataCSharp.Sandbox;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KataCSharp.LeetCode.B.KLargestElement;
namespace KataCSharp.LeetCode.B
{
	//Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
	//If target is not found in the array, return [-1, -1].
	//You must write an algorithm with O(log n) runtime complexity.
	// [5,7,7,8,8,10] 8 [3,4]
	public class SearchForARange
	{

		[Theory]
		[MemberData(nameof(GetTestData))]
		public void SearchForARangeTest(TestData testData, int[] res)
		{
			var arr = testData.nums;
			var k = testData.k;

			var r = SearchForARangeW(arr,k);
			//var r = new int[] {idx1,idx2};
			//Assert.Contains<int[]>(r,res);
			Assert.Equal(res[0], r[0]);
			Assert.Equal(res[1], r[1]);
		}

		public static int[] SearchForARangeW(int[] arr, int k)
		{
			var idx1 = -1;
			var idx2 = -1;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == k)
				{
					if (idx1 == -1) idx1 = i;
					else idx2 = i;
				}
			}

			if (idx1 != -1 && idx2 == -1)
				return new int[] { idx1, idx1 };

			return new int[] { idx1, idx2 };
		}

		public static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new TestData(new int[] { 5, 7, 7, 8, 8, 10 }, 8), new int[] { 3, 4 } };
			yield return new object[] { new TestData(new int[] { 5, 7, 7, 8, 8, 10 }, 6), new int[] { -1, -1 } };
			yield return new object[] { new TestData(new int[] { 5, 7, 7, 8, 18, 8 }, 8), new int[] { 3, 5 } };
			yield return new object[] { new TestData(new int[] { 5, 7, 7, 8 }, 8), new int[] {3,3 } };
			yield return new object[] { new TestData(new int[] { 1 }, 1), new int[] { 0, 0 } };
			yield return new object[] { new TestData(new int[] {}, 0), new int[] { -1, -1 } };
		}
	}
}
