using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.HackerRank
{
    public class Palindrome
    {
        //aaab
        //baa
        //bcbc
        public int Solution(string s) // s - string to analyze
        {
            //var mid = (int)Math.Floor((double)s.Length / 2);
            var l = new char();
            if (s.Length <= 1) return -1;
            if (s[0] == s[s.Length - 1])
            {
                l = s[0];
            }else if (s[0] == s[1])
            {
                l = s[0];
            }
            else
            {
                return -1;
            }
           return pCheck(s, l, 0, s.Length - 1);



            // if word is already palindrome or there is no solution return -1

            // otherwise return the index of character to remove
        }

        public int pCheck(string s, char prevleLetter, int left, int right)
        {
            var leftSideString = s[left];
            var rightSideString = s[right];

            if (left > right)
            {
                return -1;
            }


            if (leftSideString != rightSideString)
            {
                if (leftSideString != prevleLetter && rightSideString != prevleLetter)
                {
                    return -1;
                }else if (leftSideString != prevleLetter)
                {
                    return left;
                }
                else if (rightSideString != prevleLetter)
                {
                    return right;
                }
            }
            prevleLetter = s[left];

            left += 1;
            right -= 1;
           return pCheck(s, prevleLetter, left, right);
        }
    }
}
