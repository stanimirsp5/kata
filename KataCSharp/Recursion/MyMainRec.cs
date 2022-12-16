using KataCSharp.CSharpImplementations;
using KataCSharp.LeetCode.LinkedLists;
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
            //var f = new NumberCombinations();
            //var f = new Permutations();
            //var f = new Subsets();

            //var f = new WordSearch();
            //var f = new SelectManyImplementation();
            // var f = new GenerateParentheses();
            var f = new GroupByImplementation();


            // var f = new WordSearch();
            //var f = new SelectManyImplementation();
            // var f = new GenerateParentheses();
            //var f = new RemoveLinkedListElements();
            f.Start();
        }
    }
}

