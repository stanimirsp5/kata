using KataCSharp.Algorithms.Sorting;
using KataCSharp.CSharpImplementations;
using KataCSharp.LeetCode.B;
using KataCSharp.LeetCode.LinkedLists;
using KataCSharp.Recursion.Backtracking;
using KataCSharp.Recursion.Princeton;
using KataCSharp.Sandbox;
using KataCSharp.Sandbox.DataStructures;
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
            //var f = new GroupByImplementation();

            var f = new DictionaryExercises();

            // var f = new WordSearch();
            //var f = new SelectManyImplementation();
            // var f = new GenerateParentheses();
            //var f = new RemoveLinkedListElements();
            //var f = new PowerOfThree();
            //var f = new AddTwoNumbers();
            //var f = new OddEvenLinkedLisrt();

            //var f = new IntersectionOfTwoLinkedLists();
            //var f = new References();
            // var f = new Sum3();
          //  var f = new OrderByImplementation();
            //var f = new InsertionSort();
            //var f = new LongestPalindromicSubstring();



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

