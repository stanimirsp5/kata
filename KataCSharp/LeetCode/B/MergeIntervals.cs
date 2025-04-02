using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
   public class MergeIntervals
    {

        [Fact]
        public void TestMerge()
        {
			var intervals = new int[][]
			{
				new int[] {1, 3},
				new int[] {2, 6},
				new int[] {8, 10},
				new int[] {15, 18}
			};
			var expected = new int[][]
			{
				new int[] {1, 6},
				new int[] {8, 10},
				new int[] {15, 18}
			};

			var res = Merge(intervals);
			Assert.Equal(expected.SelectMany(el => el), res.SelectMany(el => el));
		}

        [Fact]
        public void TestMerge2()
        {
			var intervals = new int[][]
			{
				new int[] {1, 4},
				new int[] {4, 5}
			};
			var expected = new int[][]
			{
				new int[] {1, 5}
			};

			var res = Merge(intervals);
			Assert.Equal(expected.SelectMany(el => el), res.SelectMany(el => el));
		}

        [Fact]
        public void TestMerge3()
        {
			var intervals = new int[][]
			{
				new int[] {1, 3},
				new int[] {2, 4},
				new int[] {5, 8}
			};
			var expected = new int[][]
			{
				new int[] {1, 4},
				new int[] {5, 8},
			};

			var res = Merge(intervals);
			Assert.Equal(expected.SelectMany(el => el), res.SelectMany(el => el));
		}

        [Fact]
        public void TestMerge4()
        {
			var intervals = new int[][]
			{
				new int[] {1, 3}
			};
			var expected = new int[][]
			{
				new int[] {1, 3}
			};

			var res = Merge(intervals);
			Assert.Equal(expected.SelectMany(el => el), res.SelectMany(el => el));
		}


		// [[1,9],[2,6],[5,10],[2,3]]
		// [[1,3],[2,4],[5,8]]
		public int[][] Merge(int[][] intervals)
        {
			// order by first element
			intervals = intervals.OrderBy(el => el[0]).ToArray();
			//check if second element on curr arr is bigger than first on next arr
			var numOne = intervals[0][0];
			var numTwo = intervals[0][1];
			var res = new List<int[]>(); 
			
			if (intervals.Length == 1)
				res.Add(new int[] { numOne, numTwo });

			for (int i = 1; i < intervals.Length; i++)
			{
				var arr = intervals[i];
				if(numTwo >= arr[0])
				{
					if(numTwo < arr[1])
					{
						numTwo = arr[1];
					}

					if (i == intervals.Length - 1)
						res.Add(new int[] { numOne, numTwo });
				}
				else
				{
					res.Add(new int[] { numOne, numTwo });
					numOne = arr[0];
					numTwo = arr[1];

					if(i == intervals.Length-1)
						res.Add(new int[] { numOne, numTwo });
				}

			}
			return res.ToArray();
		}

		////https://stackoverflow.com/questions/45937278/how-to-test-a-method-parameter-type-jagged-array-with-xunit
		//[Theory]
		//[InlineData( new object[] { new int[] { 1, 3 }, new int[] { 2, 4 } } )]
		//public void TestTheory(object[] arr)
		//{
		//	var tt = new object[] { new int[] { 1, 3 }, new int[] { 2, 4 } };


		//	var t = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 }};
		//}


    }
}
