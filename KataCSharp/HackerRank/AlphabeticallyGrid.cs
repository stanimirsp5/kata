using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.HackerRank
{
    public class AlphabeticallyGrid
    {


        public string GridChallenge(List<string> grid)
        {

            // order string alphabetically (AB)
            var orderedChars = grid.Select(word => word.ToCharArray().OrderBy(a => a).ToArray());
            var orderedList = orderedChars.Select(i => new string(i)).ToList();
            
            // check if cols are AB
            int prevLetter = 0;
            for (int i = 0, j = 0; j < orderedList.Count(); i++)
            {
                var letter = orderedList[i][j];
                if (prevLetter == 0)
                {
                    prevLetter = letter;
                }else if ( prevLetter > letter)
                {
                    return "NO";
                }


                if (i == orderedList.Count()-1)
                {
                    j++;
                    i = -1;
                    prevLetter = 0;
                }
            }


            return "YES";

        }

        public string Reorder(string s)
        {

            return "";
        }


    }
}
