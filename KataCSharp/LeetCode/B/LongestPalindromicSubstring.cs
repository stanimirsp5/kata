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
            var s = "babad";
            var s2 = "basrqrsababd";

            FindLongestpalindrome(s);
        }

        string FindLongestpalindrome(string s)
        {
            var t = s.Split();
            var letters = s.ToCharArray();
            var longestPalindrome = string.Empty;
            for (int i = 0; i < letters.Length; i++)
            {
                var curLetter = letters[i];

                for (int j = 0; j < letters.Length; j++)
                {
                    if(i != j && curLetter == letters[j])
                    {
                       var possiblePalindromeArr = GetArrayFromIndexes(letters, i,j);
                        if (IsPalindrome(possiblePalindromeArr) &&
                            possiblePalindromeArr.Length > longestPalindrome.Length)
                            longestPalindrome = possiblePalindromeArr.ToString();
                    }
                }
            }


            return s;
        }

        char[] GetArrayFromIndexes(char[] letters, int fromIndex, int toIndex)
        {
            char[] arr = new char[toIndex-fromIndex];
            for (int i = 0; i < letters.Length; i++)
            {
                if(i >= fromIndex && i < toIndex)
                {
                    arr[i] = letters[i];
                }
            }

            return letters;
        }

        bool IsPalindrome(char[] possiblePalindromeArr)
        {

            return false;
        }
        

    }
}
