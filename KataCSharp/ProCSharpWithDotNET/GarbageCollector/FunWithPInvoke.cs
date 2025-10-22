using System.Runtime.InteropServices;

namespace KataCSharp.ProCSharpWithDotNET.GarbageCollector
{
	public class FunWithPInvoke
	{
		const string N = "pinvokeconapp.dll";

		//[DllImport(N, EntryPoint = "multiply", CallingConvention = CallingConvention.Cdecl)]
		//internal static partial int AddNumbers(int a, int b);


		[DllImport(N, EntryPoint = "add", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		internal static extern int Add(int a, int b);

		[DllImport(N, EntryPoint = "multiply", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		internal static extern int Multiply(int a, int b);


		public void Start()
		{ 
			var t = Add(10, 20);
		}
	}
}
