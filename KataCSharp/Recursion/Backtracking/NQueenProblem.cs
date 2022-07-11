using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Recursion.Backtracking
{
    internal class NQueenProblem
    {
        List<Queen> queens = new List<Queen>();
        int X;
        int Y;
        struct Queen
        {
            public int row { get; set; }
            public int col { get; set; }

        }
        public void Start()
        {
            AuxQueen();
        }
            int[,] board = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        void AuxQueen()
        {
            X = 3;
            Y = 3;
            NQueen(0);
        }

        void NQueen(int col)
        {
            if (col > X) return;

            for (int row = 0; row < X; row++)
            {
                UpdateBoard(row,col);
                NQueen(col + 1);

            }

        }
        void UpdateBoard(int row, int col)
        {
            if (IsPositionValid(row, col)) return;

            
        }

        bool IsPositionValid(int row, int col)
        {
            // to left check
            for (int i = 0; i < col; i++)
            {
                if (board[row, col] == 1)
                {
                    return false;
                }
            }

            //upper diagonal
            for (int i = row, j = col; i >= 0; i--, j++)
            {
                if (board[i, j] == 1) return false;
            }
            
            //down diagonal
            for (int i = row, j = col; i >= 0; i--, j++)
            {
                if (board[i, j] == 1) return false;
            }

            return true;
        }

        void NQueen()
        {
            // print num of queens

            //check if can place queen
            
            //NQueen(row,col+1);
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (PlaceQueenCheck(i, j))
                    {
                        queens.Add(new Queen { row = i, col = j });
                    }
                }
            }
        }
        bool PlaceQueenCheck(int row, int col)
        {
            foreach (var queen in queens) { 
                if (queen.row == row || queen.col == col || DiagonalCheck(queen.row, queen.col,row, col))
                {
                    return false;
                }
            }
            return true;
        }
        bool DiagonalCheck(int qrow, int qcol,int row, int col)
        {
            // check down
            int downrow = qrow, downcol = qcol;
            while (downrow < X && downcol < Y)
            {
                if (downrow == row && downcol == col) return true;
                downrow++;
                downcol++;
            }

            //check up
            int uprow = qrow, upcol = qcol;

            while (uprow > 0 || upcol < Y)
            {
                if (uprow == row && upcol == col) return true;
                uprow--;
                upcol++;

            }

            return false;
        }
    }
}
