using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
	//Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix.This matrix has the following properties:

	//Integers in each row are sorted in ascending from left to right.
	//Integers in each column are sorted in ascending from top to bottom.

	//Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 5
	//Output: true

	//Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 20
	//Output: false

	public class Search2DMatrix
	{


		[Fact]
		//[MemberData(nameof(TestData))]
		public void TestSearch2DMatrix()
		{
			var matrix = new int[][]
			{
				new int[] { 1,4,7,11,15},
				new int[] { 2,5,8,12,19},
				new int[] { 3,6,9,16,22},
				new int[] { 10,13,14,17,24},
				new int[] { 18,21,23,26,30}
			};
			var target = 5;
			var res = SearchMatrix(matrix, target);
			var expectedResult = true;
			Assert.Equal(expectedResult, res);
		}

		[Fact]
		public void TestSearch2DMatrix2()
		{
			var matrix = new int[][]
			{
				new int[] { 1,4,7,11,15},
				new int[] { 2,5,8,12,19},
				new int[] { 3,6,9,16,22},
				new int[] { 10,13,14,17,24},
				new int[] { 18,21,23,26,30}
			};
			var target = 20;
			var res = SearchMatrix(matrix, target);
			var expectedResult = false;
			Assert.Equal(expectedResult, res);
		}

		public bool SearchMatrix(int[][] matrix, int target)
		{
			bool res = false;
			for (int i = 0; i < matrix.Length; i++)
			{
				res = ArrayBSearch(matrix[i],0, matrix[i].Length-1, target);
				if (res)
					return res;
			}
			return res;
		}

		[Theory]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 5, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 12, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 0, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 8, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 13, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 23, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 3, false)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 1, true)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 4, true)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 7, true)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 11, true)]
		[InlineData(new int[] { 1, 4, 7, 11, 15 }, 15, true)]
		public void TestArrSearch(int[] arr, int target, bool expectedResult)
		{
			var res = ArrayBSearch(arr, 0, arr.Length - 1, target);

			Assert.Equal(expectedResult, res);
		}


		// 1,4,7,11,15 n-4 t-5
		// s-0 e-4 m-2, s-0 e-2 m-1,s-1 e-2 m-1, s-2 e-2 return false
		// 1,4,7,11,15 n-4 t-12
		// s-0 e-4 m-2, s-3 e-4 m-3,s-4 e-4 return false
		// 1,4,7,11,15 n-4 t-0
		// s-0 e-4 m-2, s-0 e-2 m-1,s-0 e-1 m-0 return false
		// 1,4,7,11,15 n-4 t-15
		// s-0 e-4 m-2, s-3 e-4 m-3
		private bool ArrayBSearch(int[] arr, int start, int end, int num)
		{
			//break case
			if (start >= end)
			{
				if (arr[start] == num)
					return true;
				else
					return false;
			}

			int mid = (start + end) / 2;

			if (arr[mid] == num)
				return true;
			else if (arr[mid] > num)
				return ArrayBSearch(arr, start, mid, num);//left
			else if (arr[mid] <= num)
				return ArrayBSearch(arr, mid+1, end, num);//right

			return false;
		}

		//TODO iterative binary search


		public static IEnumerable<object[]> TestData()
		{
			var matrix = new int[][]
			{
				new int[] { 1,4,7,11,15},
				new int[] { 2,5,8,12,19},
				new int[] { 3,6,9,16,22},
				new int[] { 10,13,14,17,24},
				new int[] { 18,21,23,26,30}
			};
			//return matrix;
			yield return new object[] {
				new int[] { 1,4,7,11,15}
			};
		}
	}
}
