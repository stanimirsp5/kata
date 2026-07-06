using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.ProCSharpWithDotNET.Reflection
{
	public class LateBinding
	{
		public void Start()
		{
			Assembly assembly = null;
			try
			{
				assembly = Assembly.LoadFrom("CarLibrary.dll");
			}
			catch(Exception ex) {
				Console.WriteLine(ex.Message);
				return;
			}

			if(assembly != null)
			{
				CreateUsingLateBinding(assembly);
			}
			Console.ReadLine();

		}

		static void CreateUsingLateBinding(Assembly assembly)
		{
			try
			{
				assembly.GetTypes().ToList().ForEach(t => Console.WriteLine($"Assembly types: {t.FullName}"));

				//Get metadata for the Car type
				Type miniVan = assembly.GetType("CarLibrary.Car");

				// create an instance of the Car class on the fly
				object obj = Activator.CreateInstance(miniVan);
				Console.WriteLine("Created instance of type: " + obj.GetType().Name);

				//Get the MethodInfo for the TurboBoost method and invoke it
				MethodInfo mi = miniVan.GetMethod("TurboBoost");
				mi.Invoke(obj, null);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

	}
}
