using System;
using System.Runtime.InteropServices;

namespace KataCSharp.Recursion.Backtracking
{
    // Combinations - the order doesn't matter 123
    // Permutations - the order matter 123,132,213,231,312,321
    // Variations - the order matter for selected num of items 123 n-2 - 12,13,21,23,31,32
    public class Permutations
    {
        static string letters = "abc";
        static bool[] used = new bool[letters.Length];
        static char[] charArr = new char[letters.Length];
        List<string> resList = new List<string>();

        
        int nParentheses = 6;
        int pn;
        char[] pRes;
        bool[] pUsed;
        static HashSet<string> resParentheses = new HashSet<string>();
        public void Start()
        {

             //PermuteLetters(0);
            //string str = "abc";

            //InPlacePerm(str, 0, str.Length - 1);
            string parentheses = GenerateParentheses(nParentheses);
            pn = parentheses.Length;
            pRes = new char[pn];
            pUsed = new bool[pn];
            PermuteParentheses(0, parentheses);

            //AreParenthesesValid("()()",0,0,0);
           //var v = ArePValid(")");

        }
        public IList<string> GenerateParenthesis(int n)
        {
            var t = resParentheses.ToList();
            return t;
        }

            void PermuteParentheses(int index, string parentheses)
        {
            if(index >= pn)
            {
                if (ArePValid(pRes)){
                    resParentheses.Add(new string(pRes));
                }
                return;
            }

            for (int i = 0; i < pn; i++)
            {
                if (!pUsed[i])
                {
                    pUsed[i] = true;
                    pRes[index] = parentheses[i];
                    PermuteParentheses(index + 1, parentheses);
                    pUsed[i] = false;
                }
            }
        }
        string GenerateParentheses(int n)
        {
            string init = string.Empty;
            int i = 0;
            while(i < n)
            {
                init += "()";
                i++;
            }

            return init;
        }
        bool ArePValid(char[] chars)
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
        bool AreParenthesesValid(string str, int index, int start, int end)
        {
            if (index >= str.Length)
                if (start < end && str[start] == '(' && str[end] == ')') return true;
                else return false;

            if (str[index] == '(') start = index;
            else end = index;

            return AreParenthesesValid(str, index + 1, start,end);
        }
        bool ArePValid(string str)
        {
            var chars = str.ToCharArray();
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
       

        void PermuteLetters(int index)
        {

            if(index >= letters.Length)
            {
                Common.PrintArray(charArr);
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    charArr[index] = letters[i];
                    PermuteLetters(index + 1);
                    used[i] = false;
                }
            }

        }

        void PermuteWithRepetition(int index)
        {

            if(index >= letters.Length)
            {
                Common.PrintArray(charArr);
                return;
            }

            for (int s = 0; s < letters.Length; s++)
            {
                charArr[index] = letters[s];
                PermuteWithRepetition(index + 1);
            }

        }

        void InPlacePerm(string str, int s, int e)
        {

            if(s >= e)
            {
                Console.WriteLine(str);
                return;
            }

            for (int i = s; i <= e; i++)
            {
                Swap(ref str, s, i);
                InPlacePerm(str, s + 1, e);
                Swap(ref str, i, s);

            }
        }
        void Swap(ref string str, int s, int e)
        {
            char[] charArr = str.ToCharArray();
            char temp = charArr[s];
            charArr[s] = charArr[e];
            charArr[e] = temp;
            str = new string(charArr);
        }
    }
}