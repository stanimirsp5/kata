using KataCSharp.ProCSharpWithDotNET.IEnumerableAndIEnumerator;

namespace KataCSharp.ProCSharpWithDotNET.GarbageCollector;

public class FunWithGarbageCollector
{
	public void Start()
	{
		//CallSystemGC();
		FinalizeClass();

		GC.AddMemoryPressure(2147483647);
		GC.Collect();
		GC.WaitForPendingFinalizers();
		// todo check in which generation is animals class
		Console.WriteLine("Write input: ");
		Console.ReadLine();
	}

	public void CallSystemGC()
	{
		Console.WriteLine("***** Fun with System.GC *****");

		Console.WriteLine("Estimated bytes on head: {0}", GC.GetTotalMemory(false));

		// Print number of generations.
		Console.WriteLine("Number of generations: {0}", GC.MaxGeneration + 1);

		var car = new Car("Zippy");
		Console.WriteLine("Generation of car is: {0}", GC.GetGeneration(car));

	}

	private void FinalizeClass()
	{
		var count = 5_000_000;
		Animal[] animals = new Animal[count];
		
		for (int i = 0; i < count; i++)
		{
			animals[i] = new Animal($"Animal {i}");
		}

		animals = null;
	}


	class Animal
	{
		public string Name { get; set; }

		public Animal(string name)
		{
			Name = name;
		}

		~Animal()
		{
			Console.WriteLine("Finalizing {0}", Name);
			Console.Beep();
		}
	}

}