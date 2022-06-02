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
        public void MyMain()
        {
            int[,] arr = new int[,] { { 1,1,1 },{ 1,0,1 },{ 1,1,1 }, { 1, 1, 1 } };
            nRow = arr.GetLength(0);
            nCol = arr.GetLength(1);

            TraverseMatrix(arr);
        
        }

        public void TraverseMatrix(int[,] arr)
        {
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {

                    if (arr[i,j] == 0)
                    {
                        SetZeroes(i,j, arr);
                        return;
                    }

                }
            }

        }
        public void SetZeroes(int row, int col, int[,] arr)
        {
            //set row
            for (int j = 0; j < nCol; j++)
            {
                    arr[row, j] = 0;
            }
            //set col
            for (int k = 0; k < nRow; k++)
            {
                for (int m = col; m < col+1; m++)
                {
                    arr[k, m] = 0;
                }
            }
        }
    }
}
