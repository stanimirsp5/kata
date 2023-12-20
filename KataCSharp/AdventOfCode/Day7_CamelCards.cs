using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.AdventOfCode
{
	public class Day7_CamelCards
	{
		public readonly string[] allCards = new string[] { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
		public List<int> orderIndex = new List<int>();
		public void Start()
		{
			int[] arr = new int[] { 12, 11, 13, 5, 6 };
			FindNum(arr);
		}

		public int DetermineTotalWinings(string[] inputs)
		{
			var orderedHands = new Dictionary<string, int>();
			//1 Order by type
			foreach (var item in inputs)
			{
				var handAndBet = item.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				OrderByType(handAndBet[0]);
			}

			//2 If cards are equal after first order. Order by comparing

			return 0;
		}

		//12, 11, 13, 5, 6
		void FindNum(int[] arr)
		{
			//int j = 1;
			for (int i = 1; i < arr.Length; i++)
			{
				int key = arr[i];
				int j = i - 1;
				while (j >= 0 && arr[j] > key)
				{
					arr[j+1] = arr[j];
					j--;
				}
				arr[j+1] = key;
			}
		}	
		
		void FindNum2(int[] arr)
		{
			//int j = 1;
			for (int i = 0; i < arr.Length; i++)
			{
				int j = i + 1;
				int k = i;
				while (k >= 0 && j < arr.Length && arr[k] > arr[j])
				{
					var temp = arr[k];
					arr[k] = arr[j];
					arr[j] = temp;
					k--;
					j--;
				}
			}
		}

		void OrderByType(string input)
		{

		}
		//Ordering based on type
		bool IsFiveOfKind(string cards) => false;
		bool IsFourOfKind(string cards) => false;
		bool IsFullHouse(string cards) => false;
		bool IsThreeOfKind(string cards) => false;
		bool IsTwoPair(string cards) => false;
		bool IsOnePair(string cards) => false;
		bool IsHighCard(string cards) => false;

	}
}
