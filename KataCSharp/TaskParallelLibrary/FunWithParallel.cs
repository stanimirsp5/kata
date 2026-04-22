using System.Diagnostics;

namespace KataCSharp.TaskParallelLibrary
{
	public class FunWithParallel
	{
		public async Task Start()
		{
			for (int i = 0; i < 10; i++)
			{

				ProcessIntData();
				ProcessIntDataParallel();
				Console.WriteLine("End");
				await Task.Delay(1000);
			}
		}

		void ProcessIntData()
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var source = Enumerable.Range(1, 1000000);
			var modThreeIsZero = source.Where(num => num % 3 == 0);
			var count = modThreeIsZero.Count();
			stopWatch.Stop();
			Console.WriteLine("Found {0} numbers divisible by 3. Stopwatch time {1}", count, stopWatch.Elapsed);
		}

		void ProcessIntDataParallel()
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var source = Enumerable.Range(1, 1000000);
			var modThreeIsZero = source.Where(num => num % 3 == 0).AsParallel();
			var count = modThreeIsZero.Count();
			stopWatch.Stop();
			Console.WriteLine("Parallel Found {0} numbers divisible by 3. Stopwatch time {1}", count, stopWatch.Elapsed);
		}
	}
}
