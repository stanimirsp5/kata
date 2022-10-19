using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class WordSearch
    {
        public void Start()
        {

            
        }


        public bool SearchWord(int index, int row, int col)
        {
            //if (!CanMove(ref row, ref col))
            //{
            //    return false;
            //}

            for (int i = 0; i < max; i++)
            {
                if(CanMove(ref row, ref col))
                {
                    SearchWord();
                }
            }

            return true;
        }

        public bool CanMove(ref int row,ref int col)
        {

            return true;
        }

    }
}

