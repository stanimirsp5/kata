using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class Permutations
    {
        static string letters = "ab";
        bool[] used = new bool[letters.Length];
        char[] charArr = new char[letters.Length];
        List<string> resList = new List<string>();
        public void Start()
        {
            
           // PermuteLetters(0);
            //string str = "abc";
            //InPlacePerm(str, 0, str.Length - 1);
            PermuteWithRepetition(0);
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

