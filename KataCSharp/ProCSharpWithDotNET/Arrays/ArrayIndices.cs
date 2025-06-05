using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.ProCSharpWithDotNET.Arrays
{
    public class ArrayIndices
    {
		public static void Start()
		{
			var arr = new int[] { 1, 2, 3, 4, 5 };
			for (int i = 0; i < arr.Length; i++)
			{
				Index idx = i;

				int res = arr[idx];
				Console.Write(res + " ");
			}
			Console.WriteLine();
			for (int i = 0; i < arr.Length; i++)
			{
				var idx = i;

				int res = arr[idx];
				Console.Write(res + " ");
			}
			Console.WriteLine();

			foreach (var item in arr[0..2])
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			Range range = 0..2;
			foreach (var item in arr[range])
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			foreach (var item in arr[1..^2])
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			var lastElement = arr[^1];
			var lastElement2 = arr.ElementAt(^1);
			var list = new List<int> { 1, 2, 3, 4, 5 };
			var listLast = list.ElementAt(^1);
			var listLast2 = list.Last();
			var listLast3 = list[^1];
			Console.WriteLine($"Last element: {lastElement}, {lastElement2}, {listLast}, {listLast2}, {listLast3}");
		}
	}

}
