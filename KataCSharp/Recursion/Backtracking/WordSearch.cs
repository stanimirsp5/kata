using System;
using System.Reflection;

namespace KataCSharp.Recursion.Backtracking
{
    public class WordSearch
    {

        static string word1 = "ABCCED";
        static char[] word = word1.ToCharArray();
        char[] tempWord = new char[word.Length];
        char[,] board = new char[,]
        {
            {'A', 'B', 'C','E' },
            {'S', 'F', 'C','S' },
            {'A', 'D', 'E','E' }
        };

        static char[][] boardM = new char[3][];

        // boardM[0] = new char[] {'A', 'B', 'C','E' };

        //    {'S', 'F', 'C','S' },
        //    {'A', 'D', 'E','E' }
        //};

        public void Start()
        {
            tempWord[0] = 'A';
            //var t = SearchWord(1, 0, 0);

            string myWord = "SEE";
            boardM[0] = new char[] { 'A', 'B', 'C', 'E' };
            boardM[1] = new char[] { 'S', 'F', 'C', 'S' };
            boardM[2] = new char[] { 'A', 'D', 'E', 'E' };
            var tt = Exist(boardM, myWord);
        }

        public bool SearchWord(int index, int row, int col)
        {
            if (Enumerable.SequenceEqual(word, tempWord))
            {
                return true;
            }

            if (CanMove(index, ref row, ref col))
            {
                tempWord[index] = word[index];
                return SearchWord(index + 1, row, col);
            }
            else
            {
                return false;
            }

        }

        public bool CanMove(int index, ref int row, ref int col)
        {
            int r = board.GetLength(0) - 1;
            int c = board.GetLength(1) - 1;

            // go right
            if ((col + 1 <= c && row <= r) && board[row, col + 1] == word[index])
            {
                ++col;
                return true;
            }
            // go left
            else if ((col - 1 >= 0 && row <= r) && board[row, col - 1] == word[index])
            {
                --col;
                return true;
            }
            // go up
            else if ((row - 1 >= 0 && col <= c) && board[row - 1, col] == word[index])
            {
                --row;
                return true;
            }
            // go down
            else if ((row + 1 <= r && col <= c) && board[row + 1, col] == word[index])
            {
                ++row;
                return true;
            }

            return false;
        }


        //
        public bool Exist(char[][] board, string word1)
        {
            char[] word = word1.ToCharArray();
            char[] tempWord = new char[word.Length];

           // tempWord[0] = 'A';
            return SearchWord(board, word, tempWord, 0, 0, 0);
        }

        public bool SearchWord(char[][] board, char[] word, char[] tempWord, int index, int row, int col)
        {
            if (Enumerable.SequenceEqual(word, tempWord))
            {
                return true;
            }

            for (int r = row; r < board[0].Length; r++)
            {
                for (int c = col; c < board[1].Length; c++)
                {
                    bool isValid = board[r][c] == word[index];
                    if (isValid)
                    {
                        tempWord[index] = word[index];
                        return SearchWord(board, word, tempWord, index + 1, r, c);
                    }
                }
            }

            return false;
        }

        public (bool,int,int) CanMove(char[][] board, char[] word, int index, int row, int col)
        {
            int r = board[0].Length - 1;
            int c = board[1].Length - 1;

            // check first
            if(board[row][col] == word[index])
            {
                return (true, row, col);
            }
            // go right
            else if ((col + 1 <= c && row <= r) && board[row][col + 1] == word[index])
            {
                ++col;
                return (true,row,col);
            }
            // go left
            else if ((col - 1 >= 0 && row <= r) && board[row][col - 1] == word[index])
            {
                --col;
                return (true, row, col);
            }
            // go up
            else if ((row - 1 >= 0 && col <= c) && board[row - 1][col] == word[index])
            {
                --row;
                return (true, row, col);
            }
            // go down
            else if ((row + 1 <= r && col <= c) && board[row + 1][col] == word[index])
            {
                ++row;
                return (true, row, col);
            }

            return (false, row, col);
        }
    }
}

