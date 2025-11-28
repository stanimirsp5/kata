namespace KataCSharp.LeetCode.A;

public class ClimbingStairs
{
	//You are climbing a staircase.It takes n steps to reach the top.

	//Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
	//Example 1:

	//Input: n = 2
	//Output: 2
	//Explanation: There are two ways to climb to the top.
	//1. 1 step + 1 step
	//2. 2 steps
	//Example 2:

	//Input: n = 3
	//Output: 3
	//Explanation: There are three ways to climb to the top.
	//1. 1 step + 1 step + 1 step
	//2. 1 step + 2 steps
	//3. 2 steps + 1 step

	//Input: n = 4
	//Output: 5
	//Explanation: There are three ways to climb to the top.
	//1. 1 step + 1 step + 1 step + 1 step
	//2. 1 step + 2 steps + 1 step
	//3. 2 step + 1 steps + 1 step
	//4. 1 step + 1 steps + 2 step
	//5. 2 steps + 2 step

	// f(n) = f(n-1) + f(n-2)
	// base case: f(1) = 1, f(2) = 2

	[Theory]
	//[InlineData(2, 2)]
	//[InlineData(3,3)]
	//[InlineData(4,5)]
	[InlineData(6, 13)]
	void ClimbingStairsTest(int n, int expectedOutput)
	{
		//PrintAllFNums(10,1,0);

		//var res = F(n);
		var res = ClimbStairs2(n);

		Assert.Equal(expectedOutput, res);
	}

	public int ClimbStairs(int n)
	{
		if (n <= 2)
			return n;

		int[] res = new int[n + 1];

		res[1] = 1;
		res[2] = 2;

		for (int i = 3; i <= n; i++)
			res[i] = res[i - 1] + res[i - 2];

		return res[n];
	}

	public int ClimbStairs2(int n)
	{
		if (n <= 2)
		{
			return n; // n = 1 -> 1 way, n = 2 -> 2 ways
		}

		int prev2 = 1; // dp[1]
		int prev1 = 2; // dp[2]

		for (int i = 3; i <= n; i++)
		{
			int curr = prev1 + prev2; // dp[i] = dp[i-1] + dp[i-2]
			prev2 = prev1;
			prev1 = curr;
		}

		return prev1; // this is dp[n]
	}


	int F(int n)
	{
		if (n != 1 || n != 2) return 0;

		Console.WriteLine(n);
		return F(n - 1) + F(n - 2);
	}

	// 1,1,2,3,5, 8, 13, 21, 34, 55, 89
	int f(int n)
	{
		if (n <= 1) return n;
		return f(n - 1) + f(n - 2);
	}
	// n = 6
	// n = 1; return 1;
	// n = 2;   
 
	// 0,1,1,2,3,5
	void PrintAllFNums(int n, int cNum, int prevNum)
	{
		if(prevNum == 0)
			Console.Write(prevNum + ", ");

		if (cNum >= n)
		{
			Console.WriteLine(cNum);
			return;
		}
		Console.Write(cNum + ", ");

		PrintAllFNums(n, cNum+prevNum, cNum);

	}
}

