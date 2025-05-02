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


		[Theory]
		[MemberData(nameof(TestData))]
		public void TestSearch2DMatrix(int test)
		{

		}

		public bool SearchMatrix(int[][] matrix, int target)
		{

			return false;
		}

		public static IEnumerable<object[]> TestData()
		{
			//var matrix = new int[][]
			//{
			//	new int[] { 1,4,7,11,15},
			//	new int[] { 2,5,8,12,19},
			//	new int[] { 3,6,9,16,22},
			//	new int[] { 10,13,14,17,24},
			//	new int[] { 18,21,23,26,30}
			//};
			//return matrix;
			yield return new object[] { };
		}

	}
}
