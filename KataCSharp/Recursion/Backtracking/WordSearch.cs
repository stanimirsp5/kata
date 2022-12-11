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
            {'B', 'F', 'C','S' },
            {'A', 'D', 'E','E' }
        };

        static char[][] boardM = new char[3][];

       

        //    {'S', 'F', 'C','S' },
        //    { 'A', 'D', 'E','E' }
        //};

        public void Start()
        {
            boardM[0] = new char[] { 'A', 'B', 'C', 'E' };
            boardM[1] = new char[] { 'B', 'F', 'C', 'S' };
            boardM[2] = new char[] { 'A', 'D', 'E', 'E' };
            string myWord = "ABA";
            var t = MyExist(boardM, myWord);
        }

        int n;
        int m;
        public bool MyExist(char[][] board, string word)
        {
            n = board.GetLength(0);
            if (n == 0) return false;
            m = board.GetLength(1);

            var isVisited = new bool[n, m];

            var result = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result = IsContainsWord(i, j, word, isVisited, 0);
                    if (result) return true;
                }
            }

            return result;
        }

        public bool IsContainsWord(int x, int y,string word, bool[,] isVisited, int wordIndex)
        {

            if(word.Length == wordIndex)
            {
                return true;
            }

            if (x >= n || x < 0 || y >= m || y < 0)
            {
                return false;
            }

            if (word[wordIndex] != boardM[x][y])
            {
                return false;
            }

            if (isVisited[x, y])
            {
                return false;
            }

            //boundaries check
            isVisited[x,y] = true;
            // int[,] directions = new int[,] { { 0, 1 }, {1,0 }, { -1,0 }, { 0 ,-1 } };// down, right, left, up
            var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };

            foreach (var direction in directions)
            {

                if(IsContainsWord(x + direction.Item1, y + direction.Item2,word, isVisited, wordIndex+1))
                {
                    return true;
                }

            }
            isVisited[x, y] = false;

            return false;
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
            bool res = false;
            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[1].Length; c++)
                {
                    bool isFirstLetterFound = board[r][c] == word[0];
                    if (isFirstLetterFound)
                    {
                        tempWord[0] = word[0];
                        res = SearchWord(board, word, tempWord, 1, r, c);
                    }
                }
            }
            return res;
            // return SearchWord(board, word, tempWord, 0, 0, 0);
        }

        public bool SearchWord(char[][] board, char[] word, char[] tempWord, int index, int row, int col)
        {
            if (Enumerable.SequenceEqual(word, tempWord))
            {
                return true;
            }
            int[] directions = new int[4];
            for (int i = 0; i < board.Length; i++)
            {
                (bool isMove, int r, int c, directions) = CanMove(board, word, index, row, col, directions);
                if (isMove)
                {
                    tempWord[index] = word[index];

                    return SearchWord(board, word, tempWord, index + 1, r, c);
                }
            }
            return false;
        }

        public (bool, int, int, int[]) CanMove(char[][] board, char[] word, int index, int row, int col, int[] directions)
        {
            int r = board.Length - 1;
            int c = board[1].Length - 1;

            // go right
            if (directions[0] == 0 && (col + 1 <= c && row <= r) && board[row][col + 1] == word[index])
            {
                ++col;
                directions[0] = 1;
                return (true, row, col, directions);
            }
            // go left
            else if (directions[1] == 0 && (col - 1 >= 0 && row <= r) && board[row][col - 1] == word[index])
            {
                --col;
                directions[1] = 1;
                return (true, row, col, directions);
            }
            // go up
            else if (directions[2] == 0 && (row - 1 >= 0 && col <= c) && board[row - 1][col] == word[index])
            {
                --row;
                directions[2] = 1;
                return (true, row, col, directions);
            }
            // go down
            else if (directions[3] == 0 && (row + 1 <= r && col <= c) && board[row + 1][col] == word[index])
            {
                ++row;
                directions[3] = 1;
                return (true, row, col, directions);
            }

            return (false, row, col, directions);
        }
    }
}

