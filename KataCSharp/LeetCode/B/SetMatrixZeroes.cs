using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class SetMatrixZeroes
    {
        public int nRow;
        public int nCol;
        public int numToSet = -11111;
        public void MyMain()
        {
            int[,] arr2 = new int[,] { {0,1,0 },{ 1,1,1 },{ 1,1,1 }, { 1, 1, 1 } };
            int[,] arr = new int[,] { { 0, 1, 2, 0 },{ 3, 4, 5, 2 },{ 1, 3, 1, 5 } };
            nRow = arr.GetLength(0);
            nCol = arr.GetLength(1);

            TraverseMatrix(arr);
            PrintMatrix(arr);
        }
        public void TraverseMatrix(int[,] arr)
        {
            var numsToZero = new List<KeyValuePair<int, int>>();

            for (int row = 0; row < nRow; row++)
            {
                for (int col = 0; col < nCol; col++)
                {
                    if (arr[row,col] == 0)
                    {
                        //fill row
                        for (int i = 0; i < nCol; i++)
                        {
                            numsToZero.Add(new KeyValuePair<int, int>( row, i));
                        }
                        //fill col
                        for (int m = 0; m < nRow; m++)
                        {
                            for (int n = col; n < col+1; n++)
                            {
                                numsToZero.Add(new KeyValuePair<int, int>(m, n));
                            }
                        }
                    }
                }
            }

            foreach (KeyValuePair<int,int> item in numsToZero)
            {
                int row = item.Key;
                int col = item.Value;
                arr[row, col] = 0;
            }
        }
        public void PrintMatrix(int[,] arr)
        {
            //arr.ForEach(el => el.ForEach(t => Console.WriteLine(t)));
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void TraverseMatrix2(int[,] arr)
        {
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {

                    if (arr[i,j] == 0)
                    {
                        SetZeroes(i,j, arr);
                    }

                }
            }

            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    if (arr[i,j] == numToSet)
                    {
                        arr[i, j] = 0;
                    }
                }
            }

        }
        public void SetZeroes(int row, int col, int[,] arr)
        {
            
            //set row
            for (int j = 0; j < nCol; j++)
            {
                if (arr[row, j] != 0)
                {
                    arr[row, j] = numToSet;
                }
            }
            //set col
            for (int k = 0; k < nRow; k++)
            {
                for (int m = col; m < col+1; m++)
                {
                    if (arr[k,m] != 0) arr[k, m] = numToSet;
                }
            }
        }
    }
}
