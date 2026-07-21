using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.A
{
	//You are given an array prices where prices[i] is the price of a given stock on the ith day.
	//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
	//Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.


	//Example 1:
	//Input: prices = [7, 1, 5, 3, 6, 4]
	//Output: 5
	//Explanation: Buy on day 2 (price = 1) and sell on day 5(price = 6), profit = 6 - 1 = 5.
	//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

	//Example 2:
	//Input: prices = [7, 6, 4, 3, 1]
	//Output: 0
	//Explanation: In this case, no transactions are done and the max profit = 0.


	//Constraints:
	//1 <= prices.length <= 105
	//0 <= prices[i] <= 104

	public class BestTimeToBuySellStock
	{
		[Theory]
		[InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
		[InlineData(new int[] { 8, 6, 4, 3, 1 }, 0)]
		[InlineData(new int[] { 2, 4, 1 }, 2)]
		[InlineData(new int[] { 17, 2, 5, 3, 6, 4, 1, 9, 8 }, 8)]
		[InlineData(new int[] { 27, 2, 5, 3, 6, 4, 1, 3 }, 4)]
		[InlineData(new int[] { 2, 1, 2, 1, 0, 1, 2 }, 2)]
		[InlineData(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }, 4)]
		public void Start(int[] prices, int expectedResult)
		{
			var res = MaxProfit(prices);

			Assert.Equal(expectedResult, res);
		}

		
		public int MaxProfit(int[] prices)
		{
			int[] minPrice = { -1 ,int.MaxValue };
			int[] maxPrice = { -1, int.MinValue };
			var profit = -1;

			for (int i = 0, j = 1; i < prices.Length; i++, j++)
			{

				if (prices[i] < minPrice[1])
				{

					var potentialProfit = minPrice[0] < maxPrice[0] ? maxPrice[1] - minPrice[1] : 0;
					profit = potentialProfit > profit ? potentialProfit : profit;

					minPrice[0] = i;
					minPrice[1] = prices[i];

					maxPrice = [-1, int.MinValue];
				}

				if (j < prices.Length && prices[j] >= maxPrice[1])
				{
					maxPrice[0] = j;
					maxPrice[1] = prices[j];
				}
			}

			var potentialProfit2 = minPrice[0] < maxPrice[0] ? maxPrice[1] - minPrice[1] : 0;
			profit = potentialProfit2 > profit ? potentialProfit2 : profit;

			return profit;
		}

	}
}
