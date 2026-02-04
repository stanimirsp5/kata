using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.SemaphoreExercises
{
    public class SemaphoreSlimInitCountSandbox
    {
		private static SemaphoreSlim semaphoreSlim;
		private static Semaphore semaphore;

		// A padding interval to make the output more orderly.
		private static int padding;

		public async Task Start()
		{

			MaxTwoThreads();
		}

		public void MaxTwoThreads()
		{
			try
			{
				semaphore = Semaphore.OpenExisting("SemaphoreDemo");
			}
			catch (Exception)
			{
				semaphore = new Semaphore(2,2, "SemaphoreDemo");
			}

			Console.WriteLine("External Thread Trying to Acquiring");
			semaphore.WaitOne();
			//This section can be access by maximum two external threads: Start
			Console.WriteLine("External Thread Acquired");
			Console.ReadKey();
			//This section can be access by maximum two external threads: End
			semaphore.Release();

		}


		public async Task Main()
		{
			// Create the semaphoreSlim.
			semaphoreSlim = new SemaphoreSlim(3,3);
			Console.WriteLine("{0} tasks can enter the semaphoreSlim.",
							  semaphoreSlim.CurrentCount);
			Task[] tasks = new Task[5];

			// Create and start five numbered tasks.
			for (int i = 0; i <= 4; i++)
			{

				tasks[i] = Task.Run(async () =>
				{
					// Each task begins by requesting the semaphoreSlim.
					Console.WriteLine("Task {0} begins and waits for the semaphoreSlim.",
									  Task.CurrentId);

				await semaphoreSlim.WaitAsync();
					int semaphoreCount;
					try
					{
						Interlocked.Add(ref padding, 100);

						Console.WriteLine("Task {0} enters the semaphoreSlim.", Task.CurrentId);

						// The task just sleeps for 1+ seconds.
						Thread.Sleep(1000 + padding);
					}
					finally
					{
						semaphoreCount = semaphoreSlim.Release();
					}
					Console.WriteLine("Task {0} releases the semaphoreSlim; previous count: {1}.",
									  Task.CurrentId, semaphoreCount);
				});
			}

			// Wait for half a second, to allow all the tasks to start and block.
			Thread.Sleep(500);

			// Restore the semaphoreSlim count to its maximum value.
			Console.Write("Main thread calls Release(3) --> ");
			//semaphoreSlim.Release(3);
			Console.WriteLine("{0} tasks can enter the semaphoreSlim.",
							  semaphoreSlim.CurrentCount);
			// Main thread waits for the tasks to complete.
			Task.WaitAll(tasks);

			Console.WriteLine("Main thread exits.");
		}
	}
}
