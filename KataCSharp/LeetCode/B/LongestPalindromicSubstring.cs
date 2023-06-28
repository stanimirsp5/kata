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
            if(letters.Length == 0) return longestPalindrome;
           else if (letters.Length <= 2)
                return s[0].ToString();

            for (int i = 0; i < letters.Length; i++)
            {
                var curLetter = letters[i];

                for (int j = 0; j < letters.Length; j++)
                {
                    if(i != j && i <= j && curLetter == letters[j])
                    {
                       var possiblePalindromeArr = GetArrayFromIndexes(letters, i,j);
                        if (IsPalindrome(possiblePalindromeArr) &&
                            possiblePalindromeArr.Length > longestPalindrome.Length)
                            longestPalindrome = string.Join("", possiblePalindromeArr);
                    }
                }
            }


            return longestPalindrome;
        }

        char[] GetArrayFromIndexes(char[] letters, int fromIndex, int toIndex)
        {
            char[] arr = new char[(toIndex-fromIndex)+1];
            for (int i = fromIndex, j = 0; j < arr.Length; i++,j++)
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

                if(possiblePalindromeArr[startIdx] == possiblePalindromeArr[endIdx]) 
                    continue;
                else
                    return false;

            }
            return true;
        }
        

    }
}
