using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.Span
{
    public class FunWithSpan
    {
		public void Start()
		{
			var str = "09/07/2025";
			var day = str.Substring(0, 2);
			var month = str.Substring(3, 2);
			var year = str.Substring(6, 2);

			var day2 = day;
			var daySpan = str.AsSpan(0, 2);






		}




	}
}
