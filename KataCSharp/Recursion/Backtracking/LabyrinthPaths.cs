using System;
using System.Collections.Generic;

namespace AlgorithmsSoftuni.Recursion.Backtracking
{
    public class LabyrinthPaths
    {
        static int mazeRow = 3;
        static int mazeCol = 5;
        string stringMaze = "----*---e"; // ---
                                         // -*-
                                         // --e
        static List<string> stringPath = new List<string>();
        static bool[,] markedDistance = new bool[mazeRow, mazeCol];
        //string[,] maze = [["---"],["-*-"],["--e"]];
        //string[,] Tablero = new string[3, 3];
        //static string[,] maze = new string[3, 3] {
        //                                {"-","-","-"},
        //                                {"-","*","-"},
        //                                {"-","-","e"} };
        static string[,] maze = new string[3, 5] {
                                        {"-","*","*","-","e"},
                                        {"-","-","-","-","-"},
                                        {"*","*","*","*","*"} };

        public static void FindPath(int row, int col, string direction = null)
        {
            if (!IsPath(row, col)) return;

            stringPath.Add(direction);

            if (maze[row, col] == "e")
            {
                PrintSolution();
            }
            else
            {

                markedDistance[row, col] = true;

                FindPath(row, col - 1, "L");// left
                FindPath(row, col + 1, "R");// right
                FindPath(row - 1, col, "U");// up
                FindPath(row + 1, col, "D");// down

            }
            stringPath.Remove(direction);
            markedDistance[row, col] = false;

        }

        private static bool IsPath(int row, int col)
        {
            if (
                 row < 0 || col < 0 || row >= mazeRow || col >= mazeCol ||
                     maze[row, col] == "*" ||
                     markedDistance[row, col] == true
                     )
            {
                return false;
            }
            return true;
        }

        private static void PrintSolution()
        {
            foreach (var item in stringPath)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
