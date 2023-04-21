using KataCSharp.CSharpImplementations;
using KataCSharp.LeetCode.LinkedLists;
using KataCSharp.Recursion.Backtracking;
using KataCSharp.Recursion.Princeton;
using KataCSharp.Sandbox;
using KataCSharp.TaskParallelLibrary;
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
            //var f = new PowerOfThree();
            //var f = new AddTwoNumbers();
            //var f = new OddEvenLinkedLisrt();

            //var f = new IntersectionOfTwoLinkedLists();
            //var f = new References();
            f.Start();
        }
    }
    public class MyMainAsync
    {
        public async Task RunMainAsync()
        {
            //Tasks
            //var f = new TaskMain();

            //await f.Start();
        }
    }
}

