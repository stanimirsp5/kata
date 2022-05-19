using System;
using System.Collections.Generic;

namespace AlgorithmsSoftuni.Recursion.Backtracking
{
    public class QueensProblemSolution
    {
        //static void Main(string[] args)
        //{
        //    PutQueens(0);
        //}

        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        static int solutionsFound = 0;

        static HashSet<int> attackedRows = new HashSet<int>(); // rows are 8 numbered from 7 to 0
        static HashSet<int> attackedColumns = new HashSet<int>(); // 8 numbered from 7 to 0
        // 15 numbered from -7 to 7, formula to calculate leftDaig = col - row
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        // 15 numbered from 0 to 14, formula to calculate rightDaig = col + row
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();


        public static void PutQueens(int row)
        {
            if(row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row,col);
                    }
                }
            }
        }

        static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied =
                attackedRows.Contains(row) ||
                attackedColumns.Contains(col) ||
                attackedLeftDiagonals.Contains(row - col) ||
                attackedRightDiagonals.Contains(row + col);
            return !positionOccupied;
        }

        static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(row - col);
            attackedRightDiagonals.Add(row + col);
            chessboard[row, col] = true;
        }

        static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(row - col);
            attackedRightDiagonals.Remove(row + col);
            chessboard[row, col] = false;
        }

        static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    var message = chessboard[row, col] ? "* " : "- ";
                    Console.Write(message);
                }
                Console.WriteLine();
            }
            solutionsFound++;
            Console.WriteLine();
           // Console.WriteLine("solutionsFound " + solutionsFound);
        }
    }
}
