﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.Semaphore
{
    public class SemaphoreSlimInitCountSandbox
    {
		private static SemaphoreSlim semaphore;
		// A padding interval to make the output more orderly.
		private static int padding;

		public async Task Start()
		{

			await Main();
		}


		public async Task Main()
		{
			// Create the semaphore.
			semaphore = new SemaphoreSlim(3,3);
			Console.WriteLine("{0} tasks can enter the semaphore.",
							  semaphore.CurrentCount);
			Task[] tasks = new Task[5];

			// Create and start five numbered tasks.
			for (int i = 0; i <= 4; i++)
			{

				tasks[i] = Task.Run(async () =>
				{
					// Each task begins by requesting the semaphore.
					Console.WriteLine("Task {0} begins and waits for the semaphore.",
									  Task.CurrentId);

				await semaphore.WaitAsync();
					int semaphoreCount;
					try
					{
						Interlocked.Add(ref padding, 100);

						Console.WriteLine("Task {0} enters the semaphore.", Task.CurrentId);

						// The task just sleeps for 1+ seconds.
						Thread.Sleep(1000 + padding);
					}
					finally
					{
						semaphoreCount = semaphore.Release();
					}
					Console.WriteLine("Task {0} releases the semaphore; previous count: {1}.",
									  Task.CurrentId, semaphoreCount);
				});
			}

			// Wait for half a second, to allow all the tasks to start and block.
			Thread.Sleep(500);

			// Restore the semaphore count to its maximum value.
			Console.Write("Main thread calls Release(3) --> ");
			//semaphore.Release(3);
			Console.WriteLine("{0} tasks can enter the semaphore.",
							  semaphore.CurrentCount);
			// Main thread waits for the tasks to complete.
			Task.WaitAll(tasks);

			Console.WriteLine("Main thread exits.");
		}
	}
}
