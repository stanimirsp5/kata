using System;
using System.Collections.Generic;

namespace AlgorithmsSoftuni.Recursion.Backtracking
{
    public class QueensProblem2
    {
        private static int Size;
        private static HashSet<int> attackedRow = new HashSet<int>();
        private static HashSet<int> attackedCol = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        private static HashSet<int> attackedRightDiagonal = new HashSet<int>();
        private static bool[,] board;
        static int solutionsFound, operationsCount = 0;

        public static void QueenProblem(int row, int size)
        {
            Size = size;
            board = new bool[size, size];
            QueenProblem(row);
        }

        private static void QueenProblem(int row)
        {

            if(Size == row)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAttackedPosition(row, col);
                        QueenProblem(row + 1);
                        UnmarkAttackedPosition(row, col);
                    }
                }
            }

        }

        private static void UnmarkAttackedPosition(int row, int col)
        {
            attackedRow.Remove(row);
            attackedCol.Remove(col);
            attackedLeftDiagonal.Remove(row - col);
            attackedRightDiagonal.Remove(row + col);
            board[row, col] = false;
        }

        private static void MarkAttackedPosition(int row, int col)
        {
            attackedRow.Add(row);
            attackedCol.Add(col);
            attackedLeftDiagonal.Add(row - col);
            attackedRightDiagonal.Add(row + col);
            board[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            if(
                attackedRow.Contains(row) ||
                attackedCol.Contains(col) ||
                attackedLeftDiagonal.Contains(row - col) ||
                attackedRightDiagonal.Contains(row + col)
                )
            {
                return false;
            }
            return true;
        }

        private static void PrintSolution()
        {

            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    var msg = board[row, col] ? " *" : " -";
                    Console.Write(msg);
                }
                operationsCount++;
            Console.WriteLine();
            }
                solutionsFound++;
                Console.WriteLine(solutionsFound + "<- | ->" + operationsCount);
        }
    }
}
