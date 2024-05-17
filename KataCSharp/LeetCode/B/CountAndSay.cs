using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    public class CountAndSay
    {
        //input : 1 , output : 11  (1 times 1)
        //input : 11 , output : 21 (2 times 1)
        //input : 21 , output : 1211 (1 times 2 and 1 times 1)
        //input : 1211 ,output : 111221 ( 1 times 1,1 times 2,2 times 1)

        //countAndSay(1) = "1"
        //countAndSay(2) = RLE of "1" = "11"
        //countAndSay(3) = RLE of "11" = "21"
        //countAndSay(4) = RLE of "21" = "1211"
        // 5 = 111221 res 312211
        // 6 = 312211 res 13112221

        public void Start()
        {
           // var res = CompressString("312211");
            var res = GetCompressedString(4);
            Console.WriteLine(res);
        }

        [Theory]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        [InlineData(6, "312211")]
        [InlineData(7, "13112221")]
        void CountAndSayTest(int input, string expectedResult)
        {
            var res = GetCompressedString(input);

            Assert.Equal(expectedResult, res);
        }

        string GetCompressedString(int n)
        {
            var strToCompress = "1";
            for (int i = 1; i < n; i++)
            {
                strToCompress = CompressString(strToCompress);
            }
            return strToCompress;
        }

        private string CompressString(string str)
        {
            char[] chars = str.ToArray();
            int count = 1;
            int prevNum = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                var num = int.Parse(chars[i].ToString());
                if (i == 0)
                {
                    if (i == chars.Length - 1)
                    {
                        var res = count.ToString() + num.ToString();
                        sb.Append(res);
                    }
                    prevNum = num;
                    continue;
                }

                if (num == prevNum)
                {
                    count++;
                }
                else if(num != prevNum)
                {
                    var res = count.ToString() + prevNum.ToString();
                    sb.Append(res);
                    prevNum = num;
                    count = 1;
                }
                if(i == chars.Length - 1)
                {
                    if (count == 1)
                    {
                        var res = count.ToString() + num.ToString();
                        sb.Append(res);
                    }
                    else
                    {
                        var res = count.ToString() + prevNum.ToString();
                        sb.Append(res);
                        prevNum = num;
                        count = 1;
                    }
                }
            }

            return sb.ToString();
        }

        //Create a helper function that maps an integer to pairs of its digits and their frequencies.
        //For example, if you call this function with "223314444411", then it maps it to an array of pairs [[2,2], [3,2], [1,1], [4,5], [1, 2]].

        //Create another helper function that takes the array of pairs and creates a new integer.
        //For example, if you call this function with [[2,2], [3,2], [1,1], [4,5], [1, 2]], it should create "22"+"23"+"11"+"54"+"21" = "2223115421".

        //Now, with the two helper functions, you can start with "1" and call the two functions alternatively n-1 times. The answer is the last integer you will obtain.

        public string CountAndSay2(int n)
        {
            string result = "1";

            for (int i = 1; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();

                char last = result[0];
                int match = 0;

                foreach (char ch in result)
                {
                    if (ch == last)
                    {
                        match++;
                    }
                    else
                    {
                        sb.Append(match);
                        sb.Append(last);
                        match = 1;
                        last = ch;
                    }
                }
                sb.Append(match);
                sb.Append(last);

                result = sb.ToString();
            }
            return result;
        }

    }
}
