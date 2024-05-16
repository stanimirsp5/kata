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
        // 5 = 111221
        // 6 = 312211

        public void Start()
        {
            var res = CompressString("111221");
            Console.WriteLine(res);
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
                    prevNum = num;
                    continue;
                }

                if (num == prevNum)
                {
                    count++;
                }
                if(num != prevNum || i == chars.Length-1)
                {
                    var res = count.ToString() + prevNum.ToString();
                    sb.Append(res);
                    prevNum = num;
                    count = 1;
                }
            }

            return sb.ToString();
        }

    }
}
