using System;
namespace KataCSharp.AdventOfCode
{
	public class Day1_Trebuchet
	{
		private readonly Dictionary<string, string> stringNumbersTemplateDict = new Dictionary<string, string>() { { "one", "1" }, { "two", "2" }, { "three", "3" }, { "four", "4" }, { "five", "5" }, { "six", "6" }, { "seven", "7" }, { "eight", "8" }, { "nine", "9" } };
		public async Task Start()
		{
			// string[] inputs = new string[]{
			//     "thfdzxfqcthqfcnrt2"
			//  };
			//string[] inputs = new string[]{
			//    "1abc2",
			//    "pqr3stu8vwx",
			//    "a1b2c3d4e5f",
			//    "treb7uchet"
			//};
			// string[] inputs = new string[]{
			//     "two1nine",
			//     "eightwothree",
			//     "abcone2threexyz",
			//     "xtwone3four",
			//     "4nineeightseven2",
			//     "zoneight234",
			//     "7pqrstsixteen"
			// };
			var inputs = AdventHelper.ReadFromFile("/Users/stanimirpetrov/Documents/Projects/kata/KataCSharp/AdventOfCode/inputs.txt");
			
			int res = FindSum(inputs);
		}

		private int FindSum(string[] inputs)
		{
			int totalSum = 0;
			foreach (var item in inputs)
			{
				string firstNum = GetFirstNum(item);
				string lastNum = GetLastNum(item);
				totalSum += int.Parse(firstNum + lastNum);
			}
			return totalSum;
		}

		private string GetFirstNum(string item)
		{
			string num = string.Empty;
			string stringNum = string.Empty;
			for (int i = 0; i < item.Length; i++)
			{
				var firstChar = item[i];
				if (char.IsDigit(firstChar))
				{
					num = firstChar.ToString();
					return num;
				}
				else if (IsStringDigit(i, item, ref stringNum))
				{
					num = stringNum;
					return num;
				}
			}
			return num;
		}

		private string GetLastNum(string item)
		{
			string num = string.Empty;
			string stringNum = string.Empty;
			for (int i = item.Length - 1; i >= 0; i--)
			{
				var firstChar = item[i];
				if (char.IsDigit(firstChar))
				{
					num = firstChar.ToString();
					return num;
				}
				else if (IsStringDigit(i, item, ref stringNum, true))
				{
					num = stringNum;
					return num;
				}
			}
			return num;
		}

		private bool IsStringDigit(int index, string item, ref string stringNum, bool isBackward = false)
		{
			var array = stringNumbersTemplateDict.Keys;

			char firstChar = item[index];
			foreach (var numTemplate in array)
			{
				int numTemplateIndex = isBackward ? numTemplate.Length - 1 : 0;
				char numTemplateFirstChar = numTemplate[numTemplateIndex];
				if (numTemplateFirstChar == firstChar)
				{
					if (isBackward && IsNumberStringBackwards(item, index, numTemplate))
					{
						stringNum = stringNumbersTemplateDict.GetValueOrDefault(numTemplate)!;
						return true;
					}
					else if (isBackward == false && IsNumberString(item, index, numTemplate))
					{
						stringNum = stringNumbersTemplateDict.GetValueOrDefault(numTemplate)!;
						return true;
					}
				}
			}
			return false;
		}

		private bool IsNumberString(string item, int index, string numTemplate)
		{
			for (int i = 0, j = index; i < numTemplate.Length - 1 && j < item.Length; i++, j++)
			{
				if (numTemplate[i] != item[j])
				{
					return false;
				}
			}
			return true;
		}

		private bool IsNumberStringBackwards(string item, int index, string numTemplate)
		{
			for (int i = numTemplate.Length - 1, j = index; i >= 0; i--, j--)
			{
				if (numTemplate[i] != item[j])
				{
					return false;
				}
			}
			return true;
		}
	}
}