using KataCSharp.ProCSharpWithDotNET.IEnumerableAndIEnumerator;

namespace KataCSharp.ProCSharpWithDotNET.GarbageCollector;

public class FunWithGarbageCollector
{
    public void Start()
    {
        // CallSystemGC();
        CallGCCollect();

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

    public void CallGCCollect()
    {
        Console.WriteLine("***** Fun with System.GC *****");

        Console.WriteLine("Estimated bytes on head: {0}", GC.GetTotalMemory(false));

        // Print number of generations.
        Console.WriteLine("Number of generations: {0}", GC.MaxGeneration + 1);

        var car = new Car("Zippy");
        Console.WriteLine("Generation of car is: {0}", GC.GetGeneration(car));

        // Make a ton of garbage.
        var tonsOfGarbage = new List<Car>();
        for (int i = 0; i < 50000; i++)
        {
            tonsOfGarbage.Add(new Car("Car " + i));
        }

        // Forcing garbage collection is bad! (for performance)
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Generation of car is: {0}", GC.GetGeneration(car));

        if (tonsOfGarbage[444] != null)
        {
            Console.WriteLine("Car 444 is alive!");
            Console.WriteLine("Generation of car 444 is {0}", GC.GetGeneration(tonsOfGarbage[444]));
        }
        else
            Console.WriteLine("Car 444 has been collected!");
    }


}