using KataCSharp.ProCSharpWithDotNET.IEnumerableAndIEnumerator;

namespace KataCSharp.ProCSharpWithDotNET.GarbageCollector;

public class FunWithGarbageCollector
{
    public void Start()
    {
        CallSystemGC();
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


}