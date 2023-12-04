namespace KataCSharp.AdventOfCode
{
	internal class Day2_CubeConundrum
	{
		internal readonly Dictionary<string, int> bagItems = new Dictionary<string, int>() { { "red", 12 }, { "green", 13 }, { "blue", 14 } };
		public async Task Start()
		{

			string[] inputs7 = new string[]
			{
				"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
				"Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
				"Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
				"Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
				"Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
			};

			var path = "C:\\Users\\stanimir.petrov\\source\\repos\\kata\\KataCSharp\\AdventOfCode\\Inputs\\input2.txt";
			var inputs = AdventHelper.ReadFromFile(path);

			var res = DetermineValidGames(inputs);
			var resSum = res.Sum();
			//var resMultiplied = MultiplyValues(res.ToArray());
		}

		private List<int> DetermineValidGames(string[] inputs)
		{
			var possibleGames = new List<int>();
			foreach (var game in inputs)
			{
				var bagItemsTemp = new Dictionary<string, int>(bagItems);
				string[] gameAndCubes = game.Split(":");
				var gameNumber = gameAndCubes[0];
				var gameOnlyNumber = int.Parse(gameNumber.Split(" ")[1]);
				var gameSets = gameAndCubes[1].Split(";");
				//CheckIfGamesArePossible(gameOnlyNumber, possibleGames, gameSets, bagItemsTemp);
				FindFewestNumberOfCubesOfEachColor(gameOnlyNumber, possibleGames, gameSets);

			}
			return possibleGames;
		}

		private void FindFewestNumberOfCubesOfEachColor(int gameOnlyNumber, List<int> powerOfSets, string[] gameSets)
		{
			var bagItemsTemp = new Dictionary<string, int>{ { "red", 0 }, { "green", 0 }, { "blue", 0 } };

			foreach (var gameSet in gameSets)
			{
				var splittedSets = gameSet.Split(",");
				foreach (var set in splittedSets)
				{
					var cube = set.Trim().Split(" ");
					var valueCubeCount = int.Parse(cube[0]);
					var keyCubeColor = cube[1];
					int bagCurrentColorValue;
					if (bagItemsTemp.TryGetValue(keyCubeColor, out bagCurrentColorValue))
					{
						if (valueCubeCount > bagCurrentColorValue)
						{
							bagItemsTemp[keyCubeColor] = valueCubeCount;
						}
					}
				}
			}

			powerOfSets.Add(MultiplyValues(bagItemsTemp.Values.ToArray()));
		}

		private int MultiplyValues(int[] arr) => arr.Aggregate(1, (acc, val) => acc * val);


		//private void CheckIfGamesArePossible(int gameNumber, List<int> possibleGames, string[] gameSets, Dictionary<string, int> bagItemsTemp)
		//{
		//	foreach (var gameSet in gameSets)
		//	{
		//		var splittedSets = gameSet.Split(",");
		//		foreach (var set in splittedSets)
		//		{
		//			var singleSet = set.Trim().Split(" ");
		//			var value = int.Parse(singleSet[0]);
		//			var key = singleSet[1];
		//			int bagCurrentColorValue;
		//			if (bagItemsTemp.TryGetValue(key, out bagCurrentColorValue))
		//			{
		//				if (bagCurrentColorValue - value < 0)
		//				{
		//					return;
		//				}
		//			}
		//		}
		//	}

		//	possibleGames.Add(gameNumber);
		//}
	}
}
