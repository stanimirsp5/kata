using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Recursion.Backtracking
{
    internal class RatInMaze
    {
       static int[,] maze = new int[,]
           {
                //{ 1, 0, 0, 0 },
                //{ 1, 1, 0, 1 },
                //{ 0, 1, 0, 0 },
                //{ 1, 1, 1, 1 }
                { 1, 1, 1, 1 },
                { 1, 0, 0, 1 },
                { 0, 1, 0, 1 },
                { 1, 1, 0, 1 }
           };

        int N = maze.GetLength(0);
        int M = maze.GetLength(1);
        int[,] mousePathMatrix;
        int[,] moves = new int[,] { { 1, 0 }, { 0, 1 } };

        public void Start()
        {
            mousePathMatrix = new int[N, M];
            mousePathMatrix[0, 0] = 1;
            MouseMaze(0, 0);
        }

        bool MouseMaze(int row,int col) {

            if (N-1 == row && M-1 == col)
            {
                Common.PrintMatrix(mousePathMatrix);
                return true;
            }

            for (int i = 0; i < moves.GetLength(0); i++)
            {

                if (CanMouseMove(moves[i,0], moves[i, 1], ref row, ref col))
                {
                    mousePathMatrix[row, col] = 1;
                    if(MouseMaze(row, col)) return true;
                    mousePathMatrix[row, col] = 0;
                }

            }

            return false;
        }
        bool CanMouseMove(int moveRow, int moveCol, ref int row, ref int col)
        {
            if(row + moveRow < N && col + moveCol < M && maze[row+moveRow, col+moveCol] ==1)
            {
                row = row + moveRow;
                col = col + moveCol;
                return true;
            }

            return false;
        }

    }
}
