using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.TaskParallelLibrary
{
    class TaskFireAndForget
	{
		public async Task Start()
		{
			WaitForTime().FireAndForget();

			WaitForTime();
		}

		async Task<DateTime> WaitForTime()
		{
			await Task.Delay(5000);

			return DateTime.Now;
		}
	

	}

	public static class Extentions
	{

		public static void FireAndForget<T>(this Task<T> task)
		{
			task.ContinueWith(t =>
			{
				if (t.IsFaulted)
				{
					throw t.Exception ?? new Exception("An error occurred in the task.");
				}
			}, TaskContinuationOptions.OnlyOnFaulted);
		}
	}
}
