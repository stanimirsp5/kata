using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.DynamicObjects
{
	public class DynamicExercise
	{
		public void Start()
		{

			dynamic student = new { Name = "test" };
			dynamic expando = new ExpandoObject();
			expando.Name = "test";
			string res = expando.Name;

			object obj = new { Name = "test" };
			obj = "test";
			// obj.ToUpperr(); // Error: 'object' does not contain a definition for 'ToUpperr'

			dynamic dyn = new { Name = "test" };
			dyn = "test";
			dyn.ToUpperr();
			dynamic t = dyn.nonExistingProperty;

			var var = new { Name = "test" };
			// var = "test"; // Error: Cannot implicitly convert type 'string' to '<anonymous type: string Name>'
		}
	}
}
