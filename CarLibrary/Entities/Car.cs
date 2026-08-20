using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary.Entities
{
	public class Car
	{
		public int Id { get; set; }  // Primary key
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }


		public void TurboBoost()
		{
			Console.WriteLine("Turbo boost activated!");
		}
	}
}
