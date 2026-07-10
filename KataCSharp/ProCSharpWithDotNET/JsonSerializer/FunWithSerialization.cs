using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KataCSharp.ProCSharpWithDotNET.JsonSerializer
{
	public class FunWithSerialization
	{
		public void Start()
		{

			var jamesBondCar = new JamesBondCar("Aston Martin", "DB5", 1964, new Radio("BBC Radio 1", 101.1, true, true));

			var options = new System.Text.Json.JsonSerializerOptions
			{
				WriteIndented = true,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				IncludeFields = true
			};
			var carJson = System.Text.Json.JsonSerializer.Serialize(jamesBondCar, options);











		}
	}

	public class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public  Radio Radio { get; set; }
		public string VIN = Guid.NewGuid().ToString();

		public Car(string make, string model, int year, Radio radio)
		{
			Make = make;
			Model = model;
			Year = year;
			Radio = radio;
		}

		public override string ToString()
		{
			return $"{Year} {Make} {Model} with radio tuned to {Radio.Station} at {Radio.Frequency}";
		}
	}

	public class Radio
	{
		public string Station { get; set; }
		public double Frequency { get; set; }
		private int ID { get; set; }
		[JsonInclude]
		public bool HasTweeters;
		[JsonInclude]
		public bool HasSubWoofers;
		[JsonInclude]
		public string InternamName { get; set; }

		public Radio(string station, double frequency, bool hasSubWoofers, bool hasTweeters, int id = 123, string internamName = "DefaultName")
		{
			Station = station;
			Frequency = frequency;
			HasSubWoofers = hasSubWoofers;
			HasTweeters = hasTweeters;
			ID = id;
			InternamName = internamName;
		}

		public override string ToString()
		{
			return $"{Station} at {Frequency}";
		}
	}

	public class JamesBondCar : Car
	{
		public JamesBondCar(string make, string model, int year, Radio radio)
			: base(make, model, year, radio)
		{
		}
		public void TurboBoost()
		{
			Console.WriteLine("Activating turbo boost!");
		}
	}

}
