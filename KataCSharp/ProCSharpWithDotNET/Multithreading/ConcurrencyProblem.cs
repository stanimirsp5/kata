namespace KataCSharp.ProCSharpWithDotNET.Multithreading;

public class ConcurrencyProblem
{
	public void Start()
	{
		var numbersPrinter = new NumbersPrinter();
		var threads = new List<Thread>();
		for (int i = 0; i < 10; i++)
		{
			threads.Add(new Thread(new ThreadStart(numbersPrinter.PrintNumbers))
			{
				Name = string.Format("Thread {0}", i)
			});
		}

		foreach (var thread in threads)
		{
			thread.Start();
		}

	}

	public class NumbersPrinter
	{
		public void PrintNumbers()
		{
			// lock (this)
			// {
			Console.WriteLine("-> {0} is executing PrintNumbers().", Thread.CurrentThread.Name);
			for (int i = 0; i < 10; i++)
			{
				//Thread.Sleep(20);
				//Console.Write("{0}, {1} ", Thread.CurrentThread.Name, i);

				Random r = new Random();
				//Thread.Sleep(r.Next(10, 100));
				//Console.Write("{0}, ", i);
				Console.Write("{0}, {1} ", Thread.CurrentThread.Name, i);

			}
			Console.WriteLine();
			// }
		}
	}

}
