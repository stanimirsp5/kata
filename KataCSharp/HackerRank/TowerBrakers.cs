using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSoftuni.HackerRank
{
    internal class TowerBrakers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BrakeTowers(1, 4));
        }

        public static int BrakeTowers(int ntowers, int height)
        {
            var towersHeights = Enumerable.Repeat(height, ntowers).ToList(); //Enumerable.Range(0, ntowers).Select(i => height).ToList();
            int currentPlayer = 2;

            while (towersHeights.Any(t => t != 1))
            {
                currentPlayer = currentPlayer == 1 ? 2 : 1;

                for (int i = 0; i < towersHeights.Count; i++)
                {
                    var tower = towersHeights[i];   

                    for (int k = 1; k < tower; k++)
                    {
                        var res = tower - k;

                        if (tower % res == 0)
                        {
                            towersHeights[i] = res;
                            goto REPEAT;
                        }
                        else
                        {

                        }
                    }
                }
            REPEAT:;
            }

            return currentPlayer;
        }

    }
}
