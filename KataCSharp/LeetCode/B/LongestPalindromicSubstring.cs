using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    public class LongestPalindromicSubstring
    {

        public void Start()
        {
            var s = "a";
            var s2 = "basrqrsababd";

            var pal = "bab";
            //var t = IsPalindrome(s.ToCharArray());
            var t = FindLongestpalindrome(s);
        }

        string FindLongestpalindrome(string s)
        {
            var letters = s.ToCharArray();
            var longestPalindrome = string.Empty;
            if (letters.Length == 0) return longestPalindrome;
            else if (letters.Length == 1) return s[0].ToString();
            else if (letters.Length == 2)
            {
                if (letters[0] == letters[1]) return s;
                else return s[0].ToString();
            }

            for (int i = 0; i < letters.Length; i++)
            {
                var curLetter = letters[i];

                for (int j = 0; j < letters.Length; j++)
                {
                    if (i != j && i <= j && curLetter == letters[j])
                    {
                        var possiblePalindromeArr = GetArrayFromIndexes(letters, i, j);
                        if (IsPalindrome(possiblePalindromeArr) &&
                            possiblePalindromeArr.Length > longestPalindrome.Length)
                            longestPalindrome = string.Join("", possiblePalindromeArr);
                    }
                }
            }

            if (longestPalindrome == string.Empty) return s[0].ToString();

            return longestPalindrome;
        }

        char[] GetArrayFromIndexes(char[] letters, int fromIndex, int toIndex)
        {
            char[] arr = new char[(toIndex - fromIndex) + 1];
            for (int i = fromIndex, j = 0; j < arr.Length; i++, j++)
            {
                arr[j] = letters[i];
            }

            return arr;
        }

        bool IsPalindrome(char[] possiblePalindromeArr)
        {
            for (int startIdx = 0, endIdx = possiblePalindromeArr.Length - 1; startIdx < possiblePalindromeArr.Length; startIdx++, endIdx--)
            {
                if (startIdx > endIdx)
                    break;

                if (possiblePalindromeArr[startIdx] != possiblePalindromeArr[endIdx])
                    return false;
            }
            return true;
        }
    }

    public class FindLongestPalindromeDynamicProgramming
    {
        public void Start()
        {
           // var s = "racecar";
            var s = "acec";
            var res = LongestPalindrome(s);
        }


        public string LongestPalindrome(string s)
        {

            int n = s.Length;
            var sArr = s.ToCharArray();
            bool[,] dp = new bool[n,n];
            int[] ans = new int[] { 0, 0 };

            for (int i = 0; i < n; i++)
            {
                dp[i,i] = true;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (sArr[i] == sArr[i + 1])
                {
                    dp[i,i + 1] = true;
                    ans[0] = i;
                    ans[1] = i + 1;
                }
            }
            //sArr=[a,c,e,c]
            for (int diff = 2; diff < n; diff++)//diff 2,3
            {
                for (int i = 0; i < n - diff; i++)//i-0,1;n-diff=2,r,1
                {
                    int j = i + diff;//2,3,r,4
                    //a==e;c==c;
                    if (sArr[i] == sArr[j] && dp[i + 1,j - 1])//dp[1,1]=false;[2,2]=false;
                    {
                        dp[i,j] = true;
                        ans[0] = i;
                        ans[1] = j;
                    }
                }
            }

            int ires = ans[0];
            int jres = ans[1];
            return s.Substring(ires,jres);
        }


    }
}
