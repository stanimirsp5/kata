using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Recursion.Backtracking
{
    internal class NumberCombinations
    {

        static int[] nums = new int[]{1,2,3};
        int[] arr = new int[2];
        int k = 2;
        int n = nums.Length;
        public void Start()
        {
            //Comb(0,0);
            // CombRepetition(0,0);
            string digits = "23";
            LetterCombinations(digits);
           
        }
        //["ad","ae","af","bd","be","bf","cd","ce","cf"]
        static char[][] matrixInit = new char[][] {
            new char[] { }, 
            new char[] { 'a', 'b' }, 
            new char[] { 'c', 'd' },
            new char[] { 'g', 'h', 'i' },
            new char[] { 'j', 'k', 'l' },
            new char[] { 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's' },
            new char[] { 't', 'u', 'v' },
            new char[] { 'w', 'x', 'y', 'z' },
        };

        char[][] matrix;
        int numCombinations;
        char[] charArr;
        List<string> list = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            numCombinations = digits.Length;
            charArr = new char[digits.Length];
            matrix = new char[digits.Length][];

            for (int i = 0; i < digits.Length; i++)
            {
                int row = int.Parse(digits[i].ToString()) - 1;

                //var t = matrix[row];
                matrix[i] = matrixInit[row];
            }

            Combinations(0, 0, 0);
            list.ForEach(l => Console.Write($"\"{l}\""));

            return list;
        }

        void Combinations(int index,int row, int col)
        {
            if (index >= numCombinations)
                //Common.PrintArray(charArr);
                list.Add(string.Join("", charArr));
            else
                for (int r = row; r < matrix.GetLength(0); r++)
                {
                    for (int c = col; c < matrix[r].Length; c++)
                    {
                        charArr[index] = matrix[r][c];
                        Combinations(index + 1, r + 1, 0);
                    }
                }
        }

        void CombRepetition(int index,int start)
        {
            if(index >= k)
                Common.PrintArray(arr);
            else
                for (int i = start; i < n; i++)
                {
                        arr[index] = nums[i];

                        CombRepetition(index + 1,i);
                }
        }

        void Comb(int index, int start)
        {
            if (index >= k)
                Common.PrintArray(arr);
            else
                for (int i = start; i < n; i++)
                {
                    arr[index] = nums[i];
                    Comb(index + 1, i + 1);
                }
        }


    }
}
