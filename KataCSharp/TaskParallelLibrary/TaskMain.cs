using System;
using System.Diagnostics;

namespace KataCSharp.TaskParallelLibrary
{
    public class TaskMain
    {
        public async Task Start()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            await Cooking();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        async Task Cooking()
        {

            Task washTask = WashVegetablesAsync();
            Task setupTask = SetupTableAsync();
            Task bakeTask = BakeAsync();

            await washTask;
            await setupTask;
            await bakeTask;

        }

        async Task BakeAsync()
        {
            Console.WriteLine("Food in baking");
            await Task.Delay(5000);
            Console.WriteLine("---Food is baked");
        }

        async Task WashVegetablesAsync()
        {
            Console.WriteLine("Washing vegetables");
            await Task.Delay(3000);
            Console.WriteLine("---Vegetables are washed");
        }

        async Task SetupTableAsync()
        {
            Console.WriteLine("Setuping the table");
            await Task.Delay(2000);
            Console.WriteLine("---Table is setuped");
        }

    }
}

