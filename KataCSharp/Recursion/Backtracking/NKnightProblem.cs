using System;
namespace KataCSharp.Recursion.Backtracking
{
    public class NKnightProblem
    {
        static int N = 5;
        int[,] board = new int[N,N];
        int counter = 1;

        public void Start()
        {
            board[0,0]= 1;
            Knight(0, 0);
            Common.PrintMatrix(board);
        }

        int[] rowMoves = new int[] { 2,1,-2,-1,2,1,-1,-2 };
        int[] colMoves = new int[] { 1,2,1,2,-1,-2,-2,-1 };
        int KNIGHT_TOTAL_MOVES = 8;

        bool Knight(int row, int col)
        {
            if(N*N == counter)
            {
                return true;
            }

            for (int i = 0; i < KNIGHT_TOTAL_MOVES; i++)
            {
                int rowM = rowMoves[i];
                int colM = colMoves[i];
                int r = rowM + row, c = colM + col;

                if (IsSafe(r, c))
                {
                    counter++;
                    board[r, c] = counter;
                   if(Knight(r, c))return true;
                    counter--;
                    board[r, c] = 0;
                }
            }
            return false;
        }

        bool IsSafe(int row, int col)
        {
            return (row < N && col < N && row >= 0 && col >= 0) && board[row, col] == 0;
        }

        bool Knight2(int row,int col)
        {
            if (N * N == counter)
            {
                Common.PrintMatrix(board);
                return true;
            }
            //if (row == N || col == N) return;

            for (int i = 0; i < 8; i++)
            {
              var (isTrue, r,c) = CanPlaceKnight(row, col, i);

                if (isTrue)
                {
                    counter++;
                    board[r, c] = counter;
                    if(Knight2(r,c)) return true;
                    counter--;
                    board[r, c] = 0;
                }
                //Console.WriteLine($"row {r} col {c}. counter {counter}. i {i}");
            }

            return false;
        }

        (bool isTrue, int r, int c) CanPlaceKnight(int row,int col, int i)
        {
            //RIGHT
            //deep down right
            if ((i == 0 && row + 2 < N && col + 1 < N) && board[row+2, col+1] == 0) return (true, row + 2, col + 1);
            //down right
            if ((i == 1 && row + 1 < N && col + 2 < N) && board[row + 1, col + 2] == 0) return (true,row + 1, col + 2);
            //deep up right
            if ((i == 2 && row - 2 > 0 && col + 1 < N) && board[row - 2, col + 1] == 0) return (true, row - 2, col + 1);
            //up right
            if ((i == 3 && row - 1 > 0 && col + 2 < N) && board[row - 1, col + 2] == 0) return (true, row - 1, col + 2);

            //LEFT
            //deep down left
            if ((i == 4 && row + 2 < N && col - 1 > 0) && board[row + 2, col - 1] == 0) return (true, row + 2, col - 1);
            //down left
            if ((i == 5 && row + 1 < N && col - 2 > 0) && board[row + 1, col - 2] == 0) return (true, row + 1, col - 2);
            //deep up left
            if ((i == 6 && row - 2 > 0 && col - 1 > 0) && board[row - 2, col - 1] == 0) return (true, row - 2, col - 1);
            //up left
            if ((i == 7 && row - 1 > 0 && col - 2 > 0) && board[row - 1, col - 2] == 0) return (true, row - 1, col - 2);

            return (false,row,col);
        }

    }
}

