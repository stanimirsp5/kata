using KataCSharp.Sandbox;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace KataCSharp.Recursion.Backtracking
{
    // Combinations - the order doesn't matter 123 n=2 12,13,23
    // Permutations - the order matter 123,132,213,231,312,321
    // Variations - the order matter for selected num of items 123 n=2 - 12,13,21,23,31,32

    //common
    public partial class Permutations
    {

        public void Start()
        {
            //new
            InitPMain();


            //old
            //PermuteLetters(0);
            //string str = "abc";

            //InPlacePerm(str, 0, str.Length - 1);
            //string parentheses = GenerateParentheses(nParentheses);
            //pn = parentheses.Length;
            //pRes = new char[pn];
            //pUsed = new bool[pn];
            //PermuteParentheses(0, parentheses);

            //AreParenthesesValid("()()",0,0,0);
            //var v = ArePValid(")");

        }
    }

//Given an array nums of distinct integers, return all the possible permutations.You can return the answer in any order.
//Example 1:
//Input: nums = [1, 2, 3]
//Output: [[1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], [3,2,1]]
//Example 2:
//Input: nums = [0,1]
//    Output: [[0,1],[1,0]]
//Example 3:
//Input: nums = [1]
//    Output: [[1]]
//Constraints:
//1 <= nums.length <= 6
//-10 <= nums[i] <= 10
//All the integers of nums are unique.

    // new
    public partial class Permutations
    {
        char[] temp;
        void InitPMain()
        {
            //string str = "abc";
            ////string str = "()()()()()()";
            //temp = new char[str.Length];
            //bool[] isUsed = new bool[str.Length];
            //HashSet<string> resParentheses = new HashSet<string>();
            //NPerm(0, 0, str, isUsed, resParentheses);
            int[] nums = new int[] { 1, 2, 3 };
            Permute(nums);
        }
        void NPerm(int index,int start, string str, bool[] isUsed, HashSet<string> resParentheses)
        {
            if (index >= str.Length)
                //if (AreParenthesesValid(temp))
                //{
                //    resParentheses.Add(new string(temp));
                Common.PrintArray(temp);
                //}
            for (int i = 0; i < str.Length; i++)
            {
                if (!isUsed[i])
                {
                    isUsed[i] = true;
                    temp[index] = str[i];
                    NPerm(index + 1, i, str, isUsed, resParentheses);
                    isUsed[i] = false;
                }
            }

        }
        List<IList<int>> listRes = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {
            DistinctIntegers(nums, new int[nums.Length], new bool[nums.Length], 0);
            return listRes;
        }
        void DistinctIntegers(int[] nums,int[] res,bool[] isUsed, int index)
        {

            if (index >= nums.Length)
            {
                Common.PrintArray(res);
                listRes.Add(res.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!isUsed[i])
                {
                    res[index] = nums[i];
                    isUsed[i]= true;
                    DistinctIntegers(nums, res, isUsed, index + 1);
                    isUsed[i] = false;
                }
            }
        }

        void DistinctIntegersInPlace(int[] nums,int arrLength, int start)
        {

            if (start >= arrLength)
            {
                Common.PrintArray(nums);
                return;
            }

            for (int i = start; i <= arrLength; i++)
            {
                SwapRes(nums, arrLength, i);
                DistinctIntegersInPlace(nums, arrLength,start + 1);

                SwapRes(nums, i, arrLength);
            }
        }
        void SwapRes(int[] nums, int start, int end)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
        }
    }

    // old
    public partial class Permutations
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
        
        public IList<string> GenerateParenthesis(int n)
        {
            var t = resParentheses.ToList();
            return t;
        }

        void PermuteParentheses(int index, string parentheses)
        {
            if(index >= pn)
            {
                if (AreParenthesesValid(pRes)){
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
        bool AreParenthesesValid(char[] chars)
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
        //bool AreParenthesesValid(string str, int index, int start, int end)
        //{
        //    if (index >= str.Length)
        //        if (start < end && str[start] == '(' && str[end] == ')') return true;
        //        else return false;

        //    if (str[index] == '(') start = index;
        //    else end = index;

        //    return AreParenthesesValid(str, index + 1, start,end);
        //}
        bool AreParenthesesValid(string str)
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