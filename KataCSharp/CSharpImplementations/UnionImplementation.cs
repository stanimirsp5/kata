using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
	public class UnionImplementation
	{
		[Theory]
		[InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
		[InlineData(new int[] { 1, 2, 3 }, new int[] { 1,2,3 }, new int[] { 1, 2, 3 })]
		public void UnionTest(int[] first, int[] second, int[] expected)
		{
			var firstList = first.ToList();
			var secondList = second.ToList();
			var actual = firstList.MyUnion(secondList);
			Assert.Equal(expected, actual);
		}
	}
	//TODO implement IEqualityComparer
	public static class UnionImpl
	{
		public static List<T> MyUnion<T>(this List<T> first, List<T> second) where T : IEquatable<T>
		{
			var res = new List<T>(first);
			for(int i = 0; i < second.Count; i++)
			{
				if(!IsDuplicate(res, second[i]))
					res.Add(second[i]);
			}
			return res;
		}
		static bool IsDuplicate<T>(List<T> list, T num) where T : IEquatable<T>
		{
			foreach(var item in list)
			{
				if (item.Equals(num))
				{
					return true;
				}
			}
			return false;
		}
	}
}
