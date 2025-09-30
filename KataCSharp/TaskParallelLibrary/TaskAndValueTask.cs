namespace KataCSharp.TaskParallelLibrary
{
    class TaskAndValueTask
    {
		public async Task Start()
		{
			//TODO check generated code in intermidiate language
			var weatherData = await GetWeatherData();
			var weatherData2 = await GetWeatherData();
			var weatherData3 = await GetWeatherData();
			
		}

		private WeatherData _weatherData;

		async ValueTask<WeatherData> GetWeatherData()
		{
			if (_weatherData != null)
			{
				Console.WriteLine("Returning cached weather data.");
				return _weatherData;
			}
			_weatherData = await GetFromDb();

			return _weatherData;
		}

		async Task<WeatherData> GetFromDb()
		{
			// Simulate a database call
			await Task.Delay(1000);
			Console.WriteLine("Data retrieved from the database.");
			var weatherData = new WeatherData { Temperature = "20°C", Condition = "Sunny" };

			return weatherData;

		}

		async Task ReturnEmpty()
		{
			await Task.CompletedTask;
		}

		async Task ReturnEmpty2()
		{
			await Task.FromResult(1);
		}

		class WeatherData
		{
			public string Temperature { get; set; }
			public string Condition { get; set; }
		}

	}
}
