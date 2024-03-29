﻿using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace KataCSharp.Recursion.Backtracking
{
    public class GenerateParentheses
    {

        public void Start()
        {
            int n = 3;
            var list = new List<string>();
            //Generate(0, new char[n*2], list);
            //Common.PrintArray(list);
            GenerateBacktracking(list, new StringBuilder(), 0, 0, n);
        }

        void GenerateBacktracking(List<string> res, StringBuilder sb, int open, int close, int n)
        {
            // print 
            if(sb.Length == n * 2)
            {
                res.Add(sb.ToString());
            }
            // add open parenthesis
            if(open < n)
            {
                sb.Append('(');
                GenerateBacktracking(res, sb, open + 1, close, n);
                sb.Remove(sb.Length - 1, 1); // sb.Length-1
            }
            // add close parenthesis
            if(open > close)
            {
                sb.Append(')');
                GenerateBacktracking(res, sb, open, close + 1, n);
                sb.Remove(sb.Length - 1,  1);
            }

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

        //public List<String> generateParenthesis(int n)
        //{
        //    List<String> ans = new ArrayList();
        //    backtrack(ans, new StringBuilder(), 0, 0, n);
        //    return ans;
        //}

        //public void backtrack(List<String> ans, StringBuilder cur, int open, int close, int max)
        //{
        //    if (cur.length() == max * 2)
        //    {
        //        ans.add(cur.toString());
        //        return;
        //    }

        //    if (open < max)
        //    {
        //        cur.append("(");
        //        backtrack(ans, cur, open + 1, close, max);
        //        cur.deleteCharAt(cur.length() - 1);
        //    }
        //    if (close < open)
        //    {
        //        cur.append(")");
        //        backtrack(ans, cur, open, close + 1, max);
        //        cur.deleteCharAt(cur.length() - 1);
        //    }
        //}
    }
}

