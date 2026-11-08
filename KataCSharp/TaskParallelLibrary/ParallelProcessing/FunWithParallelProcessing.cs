namespace KataCSharp.TaskParallelLibrary.ParallelProcessing;

class FunWithParallelProcessing
{
    public async Task Start()
    {
        await ProcessInParallel();
    }


    public async Task ProcessInParallel()
    {
        var processor = new WeatherForecastProcessor();
        var tasks = new List<Task<WeatherForecast>>();
        
        System.Console.WriteLine("Results from Task.WhenAll using direct calls");
        for (int i = 0; i < 5; i++)
        {
            tasks.Add(processor.GetWeatherForecast());
        }
        var resultsWhenAll = await Task.WhenAll(tasks);
        
        System.Console.WriteLine("Results from Task.WhenAll using Task.Run");
        for (int i = 0; i < 5; i++)
        {
            tasks.Add(Task.Run(() => processor.GetWeatherForecast()));
        }
        var resultsTask = await Task.WhenAll(tasks);
    }

    class WeatherForecast
        {
            public DateTime Date { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; } = string.Empty;
    }

    class WeatherForecastProcessor
    {
       

        public async Task<WeatherForecast> GetWeatherForecast()
        {
            int temperatureC = new Random().Next(-20, 40);
            var weatherForecast = new WeatherForecast(){
                Date = DateTime.Now,
                TemperatureC = temperatureC,
                Summary = temperatureC > 0 ? "Warm" : "Cold"
            };

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Fetching weather forecast {i} seconds...");
                await Task.Delay(1000); // Simulate some asynchronous work
            }

            return weatherForecast;
        }
    }


}