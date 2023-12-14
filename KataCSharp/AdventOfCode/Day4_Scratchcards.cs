using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.AdventOfCode
{
	internal class Day4_Scratchcards
	{
		//Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53
		public void Start()
		{
			var path = "C:\\Users\\stanimir.petrov\\source\\repos\\kata\\KataCSharp\\AdventOfCode\\Inputs\\input4.txt";
			var inputs = AdventHelper.ReadFromFile(path);
			//var res = FindWinningNumbers(inputs);
			var res = FindCards(inputs);
		}
		// card 1 has 4 winning nums, win more 4 cards two,three,four,five 
		// card 2 has two winning nums win 2x2 cards for three and four because of card2 duplicate
		int FindCards(string[] inputs)
		{
			var cardsDict = new Dictionary<int, int>();
			foreach (var input in inputs)
			{
				var splitedCardNameAndNumbers = input.Split(':');
				var splitedNumbers = splitedCardNameAndNumbers[1].Split('|');
				var splitedWinningNumbers = splitedNumbers[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
				var splitedMyNumbers = splitedNumbers[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
				var cardNumber = int.Parse(splitedCardNameAndNumbers[0].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

				var matchingNumCount = splitedWinningNumbers.Where(el => splitedMyNumbers.Contains(el)).Count();
				AddCard(cardsDict, cardNumber);

				var valuesCount = 0;
				while (cardsDict[cardNumber] > valuesCount)
				{
					for (int i = 1; i <= matchingNumCount; i++)
						AddCard(cardsDict, cardNumber + i);
					valuesCount++;
				}
			}
			return cardsDict.Values.Sum();
		}

		void AddCard(Dictionary<int, int> cardsDict, int cardNum)
		{
			if(!cardsDict.TryAdd(cardNum, 1))
				cardsDict[cardNum] = cardsDict[cardNum] + 1;
		}

		int FindWinningNumbers(string[] inputs)
		{
			var sums = new List<int>();
			var totalSum = 0;
			foreach (var input in inputs)
			{
				var splitByCard = input.Split(':')[1].Split('|');
				var splitWinningNumbers = splitByCard[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
				var splitMyNumbers = splitByCard[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);

				var matchingNumCount = splitWinningNumbers.Where(el => splitMyNumbers.Contains(el)).Count();
				var sum = 0;
				for (int i = 1; i <= matchingNumCount; i++)
				{
					if (i == 1)
						sum++;
					else
						sum *= 2;

					sums.Add(sum);
				}
				totalSum+=sum;
			}
			return totalSum;
		}
	}
}