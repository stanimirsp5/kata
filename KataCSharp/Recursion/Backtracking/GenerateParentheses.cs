using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class GenerateParentheses
    {

        public void Start()
        {
            int n = 3;
            var list = new List<string>();
            Generate(n, new char[n*2], list);
        }

        void Generate(int pos, char[] chars, List<string> res)
        {

            if (chars.Length == pos)
            {
                if (IsValid(chars))
                    res.Add(new String(chars));
            }
            else
            {
                chars[pos] = '(';
                Generate(pos + 1, chars, res);
                chars[pos] = ')';
                Generate(pos + 1, chars, res);

            }



        }

        bool IsValid(char[] chars)
        {

            return true;
        }

    }
}

