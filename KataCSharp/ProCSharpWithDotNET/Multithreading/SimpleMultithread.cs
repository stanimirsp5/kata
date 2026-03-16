namespace KataCSharp.ProCSharpWithDotNET.Multithreading;

public class SimpleMultithread
{
	public void Start()
	{
		//RunThreads();
		RunThreadsWithMethodParameters();
	}

	void RunThreadsWithMethodParameters()
	{
		Console.WriteLine("Choose thread count: ");
		AddParams ap = new AddParams(10, 10);
		
		Thread backgroundThread = new Thread(new ParameterizedThreadStart(Add));
		backgroundThread.Name = "Secondary";
		backgroundThread.Start(ap);
		Console.WriteLine("This is on the main thread, and we are finished");
	}

	void RunThreads()
	{
		Console.WriteLine("Choose thread count: ");
		string threadCount = Console.ReadLine();

		Thread primaryThread = Thread.CurrentThread;
		primaryThread.Name = "Primary";

		Console.WriteLine("-> {0} is executiong Main()", Thread.CurrentThread.Name);

		switch (threadCount)
		{
			case "2":
				Thread backgroundThread = new Thread(new ThreadStart(PrintNumbers));
				backgroundThread.Name = "Secondary";
				backgroundThread.Start();
				break;
			case "1":
				PrintNumbers();
				break;
			default:
				Console.WriteLine("Invalid thread count. Please choose 1 or 2.");
				goto case "1";
		}
		Console.WriteLine("This is on the main thread, and we are finished");
	}

	void PrintNumbers()
	{
		Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
		Console.WriteLine("Your numbers: ");
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("{0}, " + i);
			Thread.Sleep(2000);
		}
		Console.WriteLine();
	}

	void Add(object? data)
	{
		if(data is AddParams ap)
		{
			Console.WriteLine("ID of thread in Add(): {0}", Environment.CurrentManagedThreadId);
			Console.WriteLine("{0} + {1} is {2}",ap.a,ap.b,ap.a+ap.b);
		}
	}

	class AddParams
	{
		public int a, b;

		public AddParams(int num1, int num2)
		{
			a = num1;
			b = num2;
		}
	}
}
