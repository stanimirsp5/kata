using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class Permutations
    {
        static string letters = "abc";
        bool[] used = new bool[letters.Length];
        char[] charArr = new char[letters.Length];
        List<string> resList = new List<string>();
        public void Start()
        {
            
            PermuteLetters(0);

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
    }
}

