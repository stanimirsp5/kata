using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.AdventOfCode
{
	public class Day6_WaitForIt
	{
		public void Start()
		{
			var path = "C:\\Users\\stanimir.petrov\\source\\repos\\kata\\KataCSharp\\AdventOfCode\\Inputs\\input5-2.txt";
			var inputs = AdventHelper.ReadFromFile(path);
			//var res = FindWinningNumbers(inputs);
			AdventHelper.Multiply(new List<int> { 1,2,3,4});
			var res = CalculateDistance(inputs);
		}

		int CalculateDistance(string[] inputs)
		{
			var coveredRecords = new List<int>();
			var waysToWin = new List<int>();
			var time = inputs[0].Split(":")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries).Aggregate((acc, el) => acc + el);
			var distance = inputs[1].Split(":")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries).Aggregate((acc, el) => acc + el);
			
			var holdButtonDuration = 0;
			var currTime = BigInteger.Parse(time);
			var currDistance = BigInteger.Parse(distance);
			while (currTime >= holdButtonDuration)
			{
				var distanceCovered = holdButtonDuration * (currTime - holdButtonDuration);
				if(distanceCovered > currDistance)
					coveredRecords.Add(holdButtonDuration);

				holdButtonDuration++;
			}
			waysToWin.Add(coveredRecords.Count);
			
			return waysToWin.Count;
		}
		
		int CalculateDistance2(string[] inputs)
		{
			var coveredRecords = new List<int>();
			var waysToWin = new List<int>();
			var time = inputs[0].Split(":")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
			var distance = inputs[1].Split(":")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < time.Length; i++)
			{
				var holdButtonDuration = 0;
				var currTime = int.Parse(time[i]);
				var currDistance = int.Parse(distance[i]);
				while (currTime >= holdButtonDuration)
				{
					var distanceCovered = holdButtonDuration * (currTime - holdButtonDuration);
					if(distanceCovered > currDistance)
						coveredRecords.Add(holdButtonDuration);

					holdButtonDuration++;
				}
				waysToWin.Add(coveredRecords.Count);
				coveredRecords = new List<int>();
			}
			var res = AdventHelper.Multiply(waysToWin);
			return res;
		}

	}
}
