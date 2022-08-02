using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class LetterCombinations
    {

        char[,] matrix = new char[,] { { 'a','b','c'}, { 'd', 'e', 'f' } };
        List<char> res = new List<char>();
        public void Start()
        {
            Combinations(0);
        }

        public void Combinations(int depth)
        {
            if (matrix.GetLength(0) <= depth)
            {
                res.ForEach(r => Console.Write(r + " "));
                Console.WriteLine();
                return;
            }

            for (int index = 0; index < matrix.GetLength(1); index++)
            {
                res.Add(matrix[depth,index]);
                //Console.Write(matrix[depth, index]);
                Combinations(depth + 1);
            }

        }

    }
}

