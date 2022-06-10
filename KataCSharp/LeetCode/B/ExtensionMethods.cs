using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int GetLastUniqueValueKey(this Dictionary<int, string> dict, string value)
        {

            var group = dict.GroupBy(x => x.Value).Where(g => g.Key == value).Last();

            return group.Last().Key;
        }
    }
}
