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

		}
	}
}
