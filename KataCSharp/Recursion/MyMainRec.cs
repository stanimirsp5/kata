using KataCSharp.Recursion.Backtracking;
using KataCSharp.Recursion.Princeton;

using System;
namespace KataCSharp.Recursion
{
    public class MyMainRec
    {
        public void MyMain()
        {
            // Fibonnacci f = new Fibonnacci();
            //TowersOfHanoi f = new TowersOfHanoi();
            var f = new NumberCombinations();
            f.Start();
        }
    }
}

