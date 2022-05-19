using System;
namespace AlgorithmsSoftuni.Recursion.Backtracking
{
    public class QueensProblem
    {
        public void EightQueensProblem(bool[,] chessboard, bool[,] queensOnChessboard, int row, int col)
        {
            if(row >= chessboard.GetLength(0))
            {
                Console.WriteLine(String.Join("", queensOnChessboard));
                for (int i = 0; i < queensOnChessboard.GetLength(0); i++)
                {
                    for (int j = 0; j < queensOnChessboard.GetLength(0); j++)
                    {
                        var output = queensOnChessboard[i, j] ? " $ " : " - ";

                        Console.Write(output);
                    }
                    Console.WriteLine();
                }
                return;
            }

            if (chessboard[row, col] == true) // field is taken, place queen somewhere else
            {
                for (int i = 0; i < chessboard.GetLength(0); i++)
                {
                    for (int j = 0; j < chessboard.GetLength(0); j++)
                    {
                       if(queensOnChessboard[i, j])
                        {
                            queensOnChessboard[row, col] = true;
                        }
                    }
                }
            }
            else
            {
                queensOnChessboard[row, col] = true;
            }

            for (int i = 0; i < chessboard.GetLength(0); i++) // queen attack fields
            {
                chessboard[row, i] = true;
                chessboard[i, col] = true;
            }
            for (int r = 0, c =0; r < chessboard.GetLength(0); r++, c++)
            {
                chessboard[r, c] = true;
            }

            EightQueensProblem(chessboard, queensOnChessboard, row + 1, col + 1);

        }
    }
}
