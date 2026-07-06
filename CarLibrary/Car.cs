using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
	public class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; } 


		public void TurboBoost()
		{
			Console.WriteLine("Turbo boost activated!");
		}
	}
}
