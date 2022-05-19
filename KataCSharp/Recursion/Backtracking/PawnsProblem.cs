using System;
using System.Collections.Generic;

namespace AlgorithmsSoftuni.Recursion.Backtracking
{
    public class PawnsProblem
    {

        static int Size;
        static bool[,] board;
        static HashSet<int> attackedFieldLeft = new HashSet<int>();
        static HashSet<int> attackedFieldRight = new HashSet<int>();
        //HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        //HashSet<int> attackedRightDiagonal = new HashSet<int>();

        //public static void PlacePawn(int row, int size)
        //{
        //    Size = size;
        //    board = new bool[Size, Size];
        //    PlacePawn(row);
        //}
        public static void PawnProblem(int row, int size)
        {
            Size = size;
            board = new bool[Size, Size];
            PlacePawn(row);
        }

        private static void PlacePawn(int row)
        {
            if(row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlacePawn(row, col))
                    {
                        MarkAttackedPositions(row, col);
                        PlacePawn(row + 1);
                        UnmarkAttackedPositions(row, col);
                    }
                }
            }
        }

        private static bool CanPlacePawn(int row, int col)
        {
            if (
                attackedFieldLeft.Contains((row + 1) - (col - 1)) ||
                attackedFieldRight.Contains((row + 1) - (col + 1))

                )
            {
                return false;
            }
            return true;
        }

        private static void UnmarkAttackedPositions(int row, int col)
        {
            attackedFieldLeft.Remove((row + 1) - (col - 1));
            attackedFieldRight.Remove((row + 1) - (col + 1));
            board[row, col] = false;

        }

        private static void MarkAttackedPositions(int row, int col)
        {
            //attackedRow.Add(row);
            //attackedCol.Add(col);
            attackedFieldLeft.Add((row + 1) - (col - 1));
            attackedFieldRight.Add((row + 1) - (col + 1));
            board[row, col] = true;

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
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
