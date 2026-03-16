using System.Diagnostics;

namespace KataCSharp.ProCSharpWithDotNET.ProcessAppDomainsLoadContexts;
public class ProcessManipulator
{

	public void Start()
	{
		ListAllRunningProcesses();
	}


	void ListAllRunningProcesses()
	{
		var processes = Process.GetProcesses();
		foreach (var process in processes)
		{
			Console.WriteLine($"Process name: {process.ProcessName}, ID: {process.Id}");
		}

        Console.WriteLine("***********************************\n");
        Console.Write("Enter thread ID: ");
		int pId = int.Parse(Console.ReadLine());
		EnumThreadsForPid(pId);
	}

	void EnumThreadsForPid(int pId)
	{

		Process theProc = null;
		try
		{
			theProc = Process.GetProcessById(pId);
		}
		catch (ArgumentException ex)
		{
            Console.WriteLine(ex.Message);
			return;
		}

        Console.WriteLine("Here are threads used by: {0}", theProc.ProcessName);
		foreach (ProcessThread thread in theProc.Threads)
		{
			Console.WriteLine($"Thread ID: {thread.Id}, Start time: {thread.StartTime.ToShortTimeString()}, Priority: {thread.PriorityLevel}, StartAddress: {thread.StartAddress}");
		}
		Console.WriteLine("***********************************\n");
	}

}