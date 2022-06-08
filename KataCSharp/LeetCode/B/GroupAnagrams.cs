using System;
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
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Group(strs);
        }
        public IList<IList<string>> Group(string[] strs)
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

        public bool IsAnagram(string w1, string w2)
        {
            if (w1.Length != w2.Length) return false;

            var char1 = w1.ToCharArray();
            var char2 = w2.ToCharArray();

            int i = 0, j = 0;
            int n = w1.Length;
            while (i < n && j < n)
            {
                if (char1[i] == char2[j])
                {
                    i++;
                    j = -1;
                }
                j++;
            }

            if (i == n ) return true;
            else return false;
        }
    }
}
