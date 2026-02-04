using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace KataCSharp.Sandbox
{
    public class SandboxCommon
    {

        public void Start()
        {
            var result = TestMethod();
            Console.WriteLine(result);
			
		}

        public int TestMethod()
        {
            foreach (var i in Enumerable.Range(1, 10))
            {
				try
				{
					if (true)
					{
						return 1;
					}
				}
				catch (Exception)
				{

					throw;
				}
			}


			return 0;

        }

	}
}
