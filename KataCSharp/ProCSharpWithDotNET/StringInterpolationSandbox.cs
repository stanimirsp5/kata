using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.ProCSharpWithDotNET
{

    public static class StringInterpolationSandbox
    {
		public static void Start()
		{
			StringConcatenation();
			StringConcatenationMethod();
			StringInterpolation();
			StringFormat();
			StringFormatMethod();

			Console.ReadLine();
		}


		public static void StringConcatenation()
		{
			var str1 = "Hello";
			var str2 = "World";
			var str3 = "!";
			var result = str1 + " " + str2 + str3;
			Console.WriteLine(result); // Output: Hello World!
		}


		public static void StringConcatenationMethod()
		{
			var str1 = "Hello";
			var str2 = "World";
			var str3 = "!";
			var result = string.Concat(str1," ", str2, str3);
			Console.WriteLine(result); // Output: Hello World!
		}

		public static void StringInterpolation()
		{
			var str1 = "Hello";
			var str2 = "World";
			var str3 = "!";
			var result = $"{str1} {str2}{str3}{str3}";
			Console.WriteLine(result); // Output: Hello World!
		}

		public static void StringInterpolationComplex()
		{
			string mystring = "Onetwothree";
			int myVal = 7;
			string test = "eight" +
						 $"four {mystring} five {myVal}" + $"beep {myFunc()} {myVal} seven" +
						 $"six {mystring}";
		}

		static string myFunc()
		{
			return "five six seven";
		}

		public static void StringFormat()
		{
			var str1 = "Hello";
			var str2 = "World";
			var str3 = "!";
			Console.WriteLine("{0} {1}{2}", str1, str2, str3); // Output: Hello World!
		}

		public static void StringFormatMethod()
		{
			var str1 = "Hello";
			var str2 = "World";
			var str3 = "!";
			var result = string.Format("{0} {1}{2}", str1,str2,str3);
			Console.WriteLine(result); // Output: Hello World!
		}

	}
}
