using System;
namespace KataCSharp.DynamicProgramming
{
    public class LongestPalindrome
    {

        public void Start()
        {
            // var s = "bab";
            // var s = "basabad";
            var s = "racecar";
            var t = FindLongestPalindrome(s);
        }


        public string FindLongestPalindrome(string letters)
        {
            int n = letters.Length;
            bool[][] dp = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new bool[n];
            }
            int[] answer = new int[2];

            // all single elements are palindrome
            for (int i = 0; i < n; i++)
            {
                dp[i][i] = true;
            }

            // all same neighbour elements are palindrome
            for (int i = 0; i < n - 1; i++)
            {
                if (letters[i] == letters[i + 1])
                {
                    dp[i][i + 1] = true;
                    answer[0] = i;
                    answer[1] = i + 1;
                }
            }

            //"babab"
            // check threee or more elements for palindrome
            for (int diff = 2; diff < n; diff++)
            {
                for (int i = 0; i < n - diff; i++)
                {
                    int j = i + diff;
                    if (letters[i] == letters[j] && dp[i + 1][j - 1])
                    {
                        dp[i][j] = true;
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }

            var strLength = answer[1] - answer[0];
            var res = letters.Substring(answer[0], strLength + 1);
            return res;
        }
    }
}

