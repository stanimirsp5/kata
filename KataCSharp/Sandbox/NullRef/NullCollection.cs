using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.NullRef
{
	public class NullCollection
	{

		public void TestNullCollection() 
		{ 
			var testEmpty = new TestEmpty() { Name = "test", MyList = null};

			var t = testEmpty.MyList.Where(el => el > 0);

		}
	}
	class TestEmpty
	{
        public string Name { get; set; }
        public List<int> MyList { get; set; }
	}
}
