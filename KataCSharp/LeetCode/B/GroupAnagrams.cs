using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class GroupAnagrams
    {
        public void MyMain()
        {

            var r1 = LengthOfLongestSubstring(" ");//1
            var r2 = LengthOfLongestSubstring("abcabcbb");//3
            var r3 = LengthOfLongestSubstring("dvdf");//3
            var r4  =LengthOfLongestSubstring("idwvdfp");//5
            var r5  =LengthOfLongestSubstring("ohvhjdml");//6
        }

        public int LengthOfLongestSubstring(string s)
        {
            char[] chars = s.ToCharArray();
            var list = new List<char>();
            var dict = new Dictionary<int, string>();

            int maxLength = 0, i = 0;
            while (i < chars.Length) 
            {
                char ch = chars[i];
                string chs = ch.ToString();

                if (list.Contains(ch))
                {
                    i = dict.GetLastUniqueValueKey(chs) +1;
                    list = new List<char>();
                    dict = new Dictionary<int, string>();
                    continue;
                }

                dict.Add(i, chs);
                list.Add(ch);
                int c = list.Count;
                if (c > maxLength) maxLength = c;
                i++;
            }
            return maxLength;
        }


        public List<IList<string>> Group(string[] strs)
        {

            var dict = new Dictionary<string, List<string>>();

            

            foreach (var str in strs)
            {
                var w = str.ToCharArray();
                Array.Sort(w);
                var sw = new string(w);

                if(dict.TryGetValue(sw, out var list))
                {
                    list.Add(str);
                }
                else
                {
                    dict.Add(sw,new List<string> { str });
                }
            }
            var res = new List<IList<string>>(dict.Values);
            return res;

        }

        public bool IsAnagram(string w1, string w2)
        {
            var sorted1 = w1.ToCharArray();
            Array.Sort(sorted1);
            var nw1 = sorted1.ToString();
            
            var sorted2 = w2.ToCharArray();
            Array.Sort(sorted2);
            var nw2 = sorted2.ToString();

            if(nw1 == nw2)return true;

            return false;

        }


        public IList<IList<string>> Group2(string[] strs)
        {

            var list = strs.ToList();
            var res = new List<IList<string>>();
            var anagrams = new Dictionary<string, List<string>>();

            if (list.Count <= 1)
            {
                res.Add(list);
                return res;
            }

            for (int i = 0; i < list.Count; i++)
            {
                string w = list[i];
                anagrams.Add(w, new List<string> { w });

                for (int j = i; j < list.Count; j++)
                {
                    if (i == j) continue;

                    if (IsAnagram(list[i], list[j]))
                    {
                        string w2 = list[j];
                        var value = new List<string>();
                        if (anagrams.TryGetValue(w, out value))
                        {
                            value.Add(w2);
                        }
                        else
                        {
                            anagrams.Add(w2, new List<string> { w2 });
                        }
                        list.RemoveAt(j);
                        j--;
                    }
                }
                if (anagrams.ContainsKey(w))
                {
                    list.RemoveAt(i);
                }
                i = -1;
            }

            foreach (var item in anagrams)
            {
                
                    res.Add(item.Value);
            }

            return res;

        }

        public bool IsAnagram2(string w1, string w2)
        {
            if (w1.Length != w2.Length) return false;

            var char1 = w1.ToCharArray();
            var char2 = w2.ToCharArray();

            int i = 0, j = 0;
            int n = w1.Length;
            var checkedLetterIndex = new List<int>();
            while (i < n && j < n)
            {
                if (char1[i] == char2[j] && !checkedLetterIndex.Contains(j))
                {
                    checkedLetterIndex.Add(j);
                    i++;
                    j = -1;
                }
                j++;
            }

            if (i == n) return true;
            else return false;
        }
    }
}
