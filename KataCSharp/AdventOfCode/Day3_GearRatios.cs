using System.IO;
using System.Text.RegularExpressions;

namespace KataCSharp.AdventOfCode
{
	internal class Day3_GearRatios
	{
		public void Start()
		{
			var path = "C:\\Users\\stanimir.petrov\\source\\repos\\kata\\KataCSharp\\AdventOfCode\\Inputs\\input3-2.txt";
			var inputs = AdventHelper.ReadFromFile(path);
			string[,] inputMatrix = new string[inputs.Length, inputs[0].Length];
			
			for (int i = 0; i < inputMatrix.GetLength(0); i++)
			{
				var input = inputs[i];
				var spilittedInput = input.ToCharArray();

				for (int j = 0; j < inputMatrix.GetLength(1); j++)
				{
					inputMatrix[i, j] = spilittedInput[j].ToString();
				}
			}

			var res = FindNumbers2(inputMatrix);
			var resSum = res.Sum();
		}

		public List<int> FindNumbers2(string[,] inputMatrix)
		{
			var starAndNumbers = new Dictionary<string, int>();
			var resOfMultipliedNums = new List<int>();
			int rowLength = inputMatrix.GetLength(0);
			int colLength = inputMatrix.GetLength(1);
			for (int i = 0; i < rowLength; i++)
			{
				var starsPosition = new List<string>();
				var tempNums = "";
				for (int j = 0; j < colLength; j++)
				{
					if(int.TryParse(inputMatrix[i, j], out int tempNum))
					{
						tempNums += tempNum.ToString();
					} 
					else if (tempNums != "" && starsPosition.Any())
					{
						if (starAndNumbers.TryGetValue(starsPosition.First(), out int value))
							resOfMultipliedNums.Add(value * int.Parse(tempNums));
						else
							starAndNumbers.Add(starsPosition.First(), int.Parse(tempNums));
						
						tempNums = "";
						starsPosition = new List<string>();
						continue;
					}
					else
					{
						tempNums = "";
						starsPosition = new List<string>();
						continue;
					}

					if (HasNeighbourStar(inputMatrix,i,j, out string starPosition))
						starsPosition.Add(starPosition);

					// if end of the row
					if(j == colLength - 1 && tempNums != "" && starsPosition.Any())
					{
						if (starAndNumbers.TryGetValue(starsPosition.First(), out int value))
							resOfMultipliedNums.Add(value * int.Parse(tempNums));
						else
							starAndNumbers.Add(starsPosition.First(), int.Parse(tempNums));
					}
				}
			}


			return resOfMultipliedNums;
		}
		

		bool HasNeighbourStar(string[,] inputMatrix,int numRow, int numCol, out string starPosition)
		{
			int[] rows = new int[] { -1 /*up*/, 0 /*right*/, 1 /*down*/, 0 /*left*/, -1 /*up left*/, -1 /*up right*/, 1 /*down left*/, 1 /*down right*/ };
			int[] cols = new int[] { 0 /*up*/, 1 /*right*/, 0 /*down*/, -1 /*left*/, -1 /*up left*/, 1 /*up right*/, -1 /*down left*/, 1 /*down right*/};
			starPosition = string.Empty;
			for (int i = 0; i < rows.Length; i++)
			{
				int currRow = numRow - rows[i];
				int currCol = numCol - cols[i];
				if (currRow >= 0 && currRow < inputMatrix.GetLength(0) - 1
					&& currCol >= 0 && currCol < inputMatrix.GetLength(1) - 1
					&& IsStarSymbol(inputMatrix[currRow, currCol]))
				{
					starPosition = currRow.ToString() + "," + currCol.ToString();
					return true;
				}
			}
			return false;
		}
		bool IsStarSymbol(string symbol) => symbol == "*" && !int.TryParse(symbol, out int num);
		public List<int> FindNumbers(string[,] inputMatrix)
		{
			var resNumbers = new List<int>();
			int rowLength = inputMatrix.GetLength(0);
			int colLength = inputMatrix.GetLength(1);
			for (int i = 0; i < rowLength; i++)
			{
			var tempNums = "";
			bool saveNum = false;
				
				for (int j = 0; j < colLength; j++)
				{
					if(int.TryParse(inputMatrix[i, j], out int tempNum))
					{
						tempNums += tempNum.ToString();
					} 
					else if (saveNum && tempNums != "")
					{
						resNumbers.Add(int.Parse(tempNums));
						tempNums = "";
						saveNum = false;
					}
					else
					{
						tempNums = "";
					}

					if (j - 1 >= 0 //left
						&& IsSpecialSymbol(inputMatrix[i, j - 1])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (j + 1 < colLength //right
						&& IsSpecialSymbol(inputMatrix[i, j + 1])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (i - 1 >= 0 //up
						&& IsSpecialSymbol(inputMatrix[i - 1, j])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (i + 1 < rowLength // down
						&& IsSpecialSymbol(inputMatrix[i + 1, j])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (i + 1 < rowLength // down left
						&& j - 1 >= 0
						&& IsSpecialSymbol(inputMatrix[i + 1, j - 1])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (i + 1 < rowLength // down right
						&& j + 1 < colLength
						&& IsSpecialSymbol(inputMatrix[i + 1, j + 1])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (i - 1 >= 0  // up left
						&& j - 1 >= 0
						&& IsSpecialSymbol(inputMatrix[i - 1, j - 1])
						&& tempNums != "")
					{
						saveNum = true;
					}
					else if (i - 1 >= 0  // up right
						&& j + 1 < colLength
						&& IsSpecialSymbol(inputMatrix[i - 1, j + 1])
						&& tempNums != "")
					{
						saveNum = true;
					}
				}
			}


			return resNumbers;
		}
		bool IsSpecialSymbol(string symbol) => symbol != "." && !int.TryParse(symbol, out int num);
	}
}
