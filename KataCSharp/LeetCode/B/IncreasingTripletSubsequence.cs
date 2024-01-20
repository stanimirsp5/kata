using System;

namespace KataCSharp.LeetCode.B
{
	public class IncreasingTripletSubsequence
	{
		public void Start()
		{
			var arr = new int[] { 1, 2, 3, 4, 5 };
			var res = FindTriplet(arr);
			//TODO solve with backtracking
		}

		[Theory]
		[InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
		[InlineData(new int[] { 5, 4, 3, 2, 1 }, false)]
		[InlineData(new int[] { 2, 1, 5, 0, 4, 6 }, true)]
		[InlineData(new int[] { 6, 7, 1, 2 }, false)]
		[InlineData(new int[] { 1, 5, 0, 4, 1, 3 }, true)]
		[InlineData(new int[] { 20, 100, 10, 12, 5, 13 }, true)]
		public void FindTripletTest(int[] arr, bool expextedResult)
		{
			bool result = FindTripletB(arr);
			Assert.Equal(expextedResult, result);
		}

		public bool FindTripletB(int[] arr)
		{
			// 1, 5, 0, 4, 1, 3
			int maxNumIndex = 0, 
				j = 0,
				currNumIndex = 0, 
				maxNum = -100, 
				count = 0;

			while (true)
			{
				var currNum = arr[j];
				if (currNum > maxNum)
				{
					maxNum = currNum;
					maxNumIndex = j;
					count++;
				}

				if(count == 3)
				{
					return true;
				}

				if(j == arr.Length - 1)
				{
					maxNum = -100;
					count = 1;
					j = maxNumIndex;

					if(maxNumIndex == arr.Length - 1)
					{
						currNumIndex++;
						j = currNumIndex-1;
						if(currNumIndex == arr.Length - 1)return false;
					}
				}

				j++;
			}
		}

		public bool FindTripletBacktracking(int[] arr, int index)
		{
			 
			if(arr.Length == index) 
			{ 
				return false; 
			}

			if (arr[index+1]> arr[index])
			{

			}


			index++;
			return FindTripletBacktracking(arr,index);
		}

		public bool FindTriplet(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				var k = 0;
				var count = 0;
				var maxNum = arr[i];
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (maxNum < arr[j])
					{
						maxNum = arr[j];
						count++;
					}

					if (count == 2)
					{
						return true;
					}

					if (j == arr.Length - 1)
					{
						k++;
						maxNum = arr[i];
						j = i + k;
						count = 0;
					}
				}
			}
			return false;
		}

		public bool FindTriplet2(int[] arr)
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
