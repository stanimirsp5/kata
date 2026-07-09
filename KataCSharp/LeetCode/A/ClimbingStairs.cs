namespace KataCSharp.LeetCode.A;
// stop suggestions and code generations for all the code below that comment 

public class ClimbingStairs
{
	//You are climbing a staircase.It takes n steps to reach the top.
	// https://leetcode.com/explore/featured/card/top-interview-questions-easy/97/dynamic-programming/569/discuss/717739/c-yet-another-dp...
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
	[InlineData(1, 1)]
	[InlineData(2, 2)]
	[InlineData(3,3)]
	[InlineData(4,5)]
	[InlineData(6, 13)]
	[InlineData(45, 1836311903)] // 4.7 sec time limit
	void ClimbingStairsTest(int n, int expectedOutput)
	{
		
		var res = ClimbStairs(n);

		Assert.Equal(expectedOutput, res);
	}

	public Dictionary<int, int> memoSteps = new();
	
	// Memorization
	public int ClimbStairs(int n)
	{
		if (n <= 2) return n;

		if(memoSteps.TryGetValue(n, out int memoValue))
			return memoValue;

		var stepsNeeded = ClimbStairs(n - 1) + ClimbStairs(n - 2);
		memoSteps.TryAdd(n, stepsNeeded);
		
		return stepsNeeded;
	}

	// Recursion
	public int ClimbStairs4(int n)
	{
		if (n <= 2) return n;

		return ClimbStairs(n - 1) + ClimbStairs(n - 2);
	}

	

	// c(n) = c(n-1) + c(n-2)
	// c(6) = c(5) + c(4) = 13
	// c(5) = c(4) + c(3) = 8
	// c(4) = 5
	// c(3) = 3
	// c(1) = 1; c(2) = 2;

	// Tabulation
	public int ClimbStairs3(int n)
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

	// Space Optimization
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

