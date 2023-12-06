using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			var res = FindNumbers(inputMatrix);
			var resSum = res.Sum();// 4361
			Console.WriteLine(resSum);
		}

		//right, down, diagonal lower left , lower right

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
