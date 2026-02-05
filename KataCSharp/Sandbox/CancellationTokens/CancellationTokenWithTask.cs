namespace KataCSharp.Sandbox.CancellationTokens;

public class CancellationTokenWithTask
{
	public async Task Start()
	{
		//var cDatas = new List<CustomData> { new CustomData { StrName = "t1" }, new CustomData { StrName = "t2" }, new CustomData { StrName = "t3" }, new CustomData { StrName = "t4" } };
		//cDatas.ForEach(el => { el.StrName = "change"; el.Name = 1;   });

		//foreach (var item in cDatas)
		//{
		//	item.StrName = "second change";
		//	item.Name = 2;
		//}
		//cDatas.Remove(cDatas[1]);

		var ctks = new CancellationTokenSource(TimeSpan.FromSeconds(10));

		try
		{
			await RunTasksWithSemaphore(ctks.Token);

		}
		catch (Exception ex) {
            Console.WriteLine("Operation was cancelled");
		}
		Console.WriteLine("Operation finished!");
	}


	public async Task RunTasks(CancellationToken ctk)
	{
		var tasks = new List<Task>();
        Console.WriteLine($"Is cancellation requested: {ctk.IsCancellationRequested}");

		ctk.Register(() => Console.WriteLine("Callback called"));

		for (int i = 0; i < 3; i++)
		{
			int taskIndex = i;
			ctk.ThrowIfCancellationRequested();

			tasks.Add(Task.Run(async () =>
			{
				for (int j = 0; j < 3; j++)
				{
					Console.WriteLine($"Is cancellation requested: {ctk.IsCancellationRequested}");

					Console.WriteLine($"Task {Task.CurrentId} Thread {Environment.CurrentManagedThreadId}. Index {taskIndex} {j}");
					//Thread.Sleep(1000);
					await Task.Delay(1000);
				}
			}, ctk));
			//await Task.Delay(1000);

		}

		await Task.WhenAll(tasks);
	}

	public async Task RunTasksWithSemaphore(CancellationToken ctk)
	{
		var tasks = new List<Task>();
        Console.WriteLine($"Is cancellation requested: {ctk.IsCancellationRequested}");

		ctk.Register(() => Console.WriteLine("Callback called"));
		var semaphore = new SemaphoreSlim(3);


		for (int i = 0; i < 100; i++)
		{
			int taskIndex = i;
			//ctk.ThrowIfCancellationRequested();

			semaphore.Wait(ctk);

			Console.WriteLine("Add tasks");
			tasks.Add(Task.Run(async () =>
			{
				for (int j = 0; j < 3; j++)
				{
					Console.WriteLine($"Is cancellation requested: {ctk.IsCancellationRequested}");

					Console.WriteLine($"Task {Task.CurrentId} Thread {Environment.CurrentManagedThreadId}. Index {taskIndex} {j}");
					//Thread.Sleep(1000);
					await Task.Delay(1000);
				}
				semaphore.Release();
			}, ctk));
			//await Task.Delay(1000);
		}

		await Task.WhenAll(tasks);
	}

	public async Task RunTasksUseStartNew(CancellationToken ctk)
	{
		var tasks = new List<Task>();

		for (int i = 0; i < 3; i++)
		{
			tasks.Add(Task.Factory.StartNew((object? obj) =>
			{
				var data = obj as CustomData;
				if (data == null) return;

				data.ThreadNum = Thread.CurrentThread.ManagedThreadId;

			},
			new CustomData() { Name = i, CreationTime = DateTime.Now.Ticks }
			));
		}

		await Task.WhenAll(tasks);

		foreach (var task in tasks)
		{
			var data = task.AsyncState as CustomData;
			if (data != null)
				Console.WriteLine("Task #{0} created at {1}, ran on thread #{2}.",
								  data.Name, data.CreationTime, data.ThreadNum);
		}

	}
}

class CustomData
{
	public long CreationTime;
	public int Name;
	public string StrName;
	public int ThreadNum;
}
