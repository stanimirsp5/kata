using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class GenerateParentheses
    {

        public void Start()
        {
            int n = 3;
            var list = new List<string>();
            Generate(0, new char[n*2], list);
            Common.PrintArray(list);
        }

        void Generate(int pos, char[] chars, List<string> res)
        {

            if (chars.Length == pos)
            {
                if (IsValid2(chars))
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
        bool IsValid2(char[] chars)
        {

            int balance = 0;

            foreach (var parenthes in chars)
            {
                if (parenthes == '(')
                    balance++;
                else
                    balance--;
                if (balance < 0)
                    return false;
            }
            return balance == 0;
        }

        bool IsValid(char[] chars)
        {
            var stack = new Stack<char>();

            foreach (var p in chars)
            {
                if (p == '(')
                    stack.Push(')');
                else if (stack.Count == 0 || stack.Pop() != p)
                    return false;
            }

            return stack.Count == 0;
        }
    }
}

