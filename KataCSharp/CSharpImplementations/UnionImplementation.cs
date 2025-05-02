using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KataCSharp.Common.CommonObjects;

namespace KataCSharp.CSharpImplementations
{
	//https://sasan-salem.medium.com/mystery-of-equality-in-c-iequatable-t-iequalitycomparer-t-icomparable-t-icomparer-t-ab98bd2fe541
	// IEquatable - compares by equality(indicates wether two objects are equal)
	// IEqualtyComparer - is used when you need more than one equal method for different situations
	// IComparer - checks wether object is bigger, smaller or same as another object
	// IComparable - compare object itself, used when sorting and ordering

	//TODO implement IEqualityComparer
	public static class UnionImpl
	{
		public static List<T> MyUnion<T>(this List<T> first, List<T> second) where T : IEquatable<T>
		{
			var res = new List<T>(first);
			for (int i = 0; i < second.Count; i++)
			{
				if (!IsDuplicate(res, second[i]))
					res.Add(second[i]);
			}
			return res;
		}

		static bool IsDuplicate<T>(List<T> list, T num) where T : IEquatable<T>
		{
			foreach (var item in list)
			{
				if (item.Equals(num))
				{
					return true;
				}
			}
			return false;
		}
	}

	public class UnionImplementation
	{
		[Theory]
		[InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
		[InlineData(new int[] { 1, 2, 3,4 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3,4 })]
		public void UnionTest(int[] first, int[] second, int[] expected)
		{
			var tt = new List<int> { 1, 2, 3 };
			var firstList = first.ToList();
			var secondList = second.ToList();
			var actual = firstList.MyUnion(secondList);
			var employees = firstList.MyUnion(secondList);
			var actual2 = firstList.Union(secondList);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[MemberData(nameof(Data))]
		public void UnionTestObj(List<Employee> first, List<Employee> second, List<Employee> expected)
		{
			var actual = first.MyUnion(second);
			Assert.Equal(expected, actual);
		}

		public static IEnumerable<object[]> Data()
		{
			var em1 = CreateEmployees();
			var em2 = CreateEmployees2();
			var expect = em1.Concat(em2);
			yield return new object[] { em1, em2, em1 };

			var em21 = CreateEmployees("Ivan");
			var em22 = CreateEmployees2();
			var expect2 = em21.Concat(em22).Where(el => el.Id == 1 || el.Id == 2 || el.Id == 3).ToList();
			yield return new object[] { em21, em22, expect2 };

			var em31 = CreateEmployees("Ivan");
			var em32 = CreateEmployees2(phoneNumber:"088 77777779");
			var expect3 = em31.Concat(em32).ToList();
			yield return new object[] { em31, em32, expect3 };
		}

		public static List<Employee> CreateEmployees(string name = "Misho", string phoneNumber = "088 77777777")
		{
			Employee emp11 = new Employee()
			{
				Id = 1,
				Name = name,
				Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
			};
			Employee emp12 = new Employee()
			{
				Id = 2,
				Name = "Stef",
				Phones = new List<Phone>() { new Phone { Number = phoneNumber }, new Phone { Number = "1111111111" } }
			};

			return new List<Employee>() { emp11, emp12 };
		}

		public static List<Employee> CreateEmployees2(string name = "Misho", string phoneNumber = "088 77777777")
		{
			Employee emp21 = new Employee()
			{
				Id = 3,
				Name = name,
				Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
			};
			Employee emp22 = new Employee()
			{
				Id = 4,
				Name = "Stef",
				Phones = new List<Phone>() { new Phone { Number = phoneNumber }, new Phone { Number = "1111111111" } }
			};


			return new List<Employee>() { emp21, emp22 };
		}
	}
}