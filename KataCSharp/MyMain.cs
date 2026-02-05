using KataCSharp.AdventOfCode;
using KataCSharp.Algorithms.Sorting;
using KataCSharp.CSharpImplementations;
using KataCSharp.DynamicProgramming;
using KataCSharp.LeetCode.B;
using KataCSharp.LeetCode.LinkedLists;
using KataCSharp.ProCSharpWithDotNET;
using KataCSharp.ProCSharpWithDotNET.AbstarctionAndPolymorhism;
using KataCSharp.ProCSharpWithDotNET.Arrays;
using KataCSharp.ProCSharpWithDotNET.DataStructures;
using KataCSharp.ProCSharpWithDotNET.DelegatesAndEvents;
using KataCSharp.ProCSharpWithDotNET.Exceptions;
using KataCSharp.ProCSharpWithDotNET.GarbageCollector;
using KataCSharp.ProCSharpWithDotNET.IEnumerableAndIEnumerator;
using KataCSharp.ProCSharpWithDotNET.OverloadingOperators;
using KataCSharp.ProCSharpWithDotNET.Records;
using KataCSharp.Recursion.Backtracking;
using KataCSharp.Recursion.Princeton;
using KataCSharp.Sandbox;
using KataCSharp.Sandbox.CancellationTokens;
using KataCSharp.Sandbox.DataStructures;
using KataCSharp.Sandbox.Dates;
using KataCSharp.Sandbox.DynamicObjects;
using KataCSharp.Sandbox.NullRef;
using KataCSharp.Sandbox.SemaphoreExercises;
using KataCSharp.Sandbox.Span;
using KataCSharp.Sandbox.Threads;
using KataCSharp.TaskParallelLibrary;
using System;
namespace KataCSharp.Recursion
{
	public class MyMain
	{
		public void Main()
		{
			// Fibonnacci f = new Fibonnacci();
			//TowersOfHanoi f = new TowersOfHanoi();
			//var f = new NumberCombinations();
			//var f = new Permutations();
			//var f = new Subsets();

			//var f = new WordSearch();
			//var f = new SelectManyImplementation();
			//var f = new GenerateParentheses();
			//var f = new GroupByImplementation();

			//var f = new DictionaryExercises();
			// var f = new SearchInQueriable();
			//var f = new PairOfNumbers();
			//var f = new SearchInQueriable();

			//test
			// var f = new WordSearch();
			//var f = new SelectManyImplementation();
			//var f = new GenerateParentheses();
			//var f = new RemoveLinkedListElements();
			//var f = new PowerOfThree();
			//var f = new AddTwoNumbers();
			//var f = new OddEvenLinkedLisrt();

			//var f = new IntersectionOfTwoLinkedLists();
			//var f = new References();
			// var f = new Sum3();
			//  var f = new OrderByImplementation();
			//var f = new Sum3();
			//var f = new OrderByImplementation();
			//var f = new InsertionSort();
			// var f = new LongestPalindromicSubstring();
			//var f = new LongestPalindromicSubstring();
			//var f = new SortImplementation();
			// var f = new FindLongestPalindromeDynamicProgramming();
			//var f = new FindLongestPalindromeDynamicProgramming();
			//var f = new IncreasingTripletSubsequence();
			//var f = new Day2_CubeConundrum();
			//var f = new CreateFile();
			// var f = new IncreasingTripletSubsequence();
			//var f = new Day2_CubeConundrum();
			//var f = new Day3_GearRatios();

			//var f = new DynamicExercise();
			//var f = new LongestPalindrome();
			//var f = new DeadLockDemo();

			//var f = new Day4_Scratchcards();
			//var f = new Day6_WaitForIt();
			//var f = new Day7_CamelCards();
			//var f = new DaylightSavingTime();
			//var f = new CountAndSay();
			//var f = new NullCollection();
			//f.TestNullCollection();

			//var f = new FunWithSpan();
			//var f = new FunWithRecords();
			// var f = new FunWithExcpetions();
			//var f = new FunWithPolymorphism();
			//var f = new FunWithEnumerator();
			//var f = new JumpGame();
			//var f = new FunWithGarbageCollector();
			//var f = new FunWithPInvoke();
			//var f = new FunWithObservableCollection();
			//var f = new CustomConversion();
			//var f = new FunWithEvents();
			var f = new SandboxCommon();



			f.Start();

			//StringInterpolationSandbox.Start();
			//ArrayIndices.Start();
			Console.ReadLine();
		}
	}
	public class MyMainAsync
	{
		public async Task RunMainAsync()
		{
			//Tasks
			//var f = new TaskMain();
			//var f = new Day1_Trebuchet();
			//var f = new SemaphoreSlimInitCountSandbox();
			var f = new CancellationTokenWithTask();
			//var f = new TaskAndValueTask();



			await f.Start();

			Console.ReadLine();
		}
	}
}

