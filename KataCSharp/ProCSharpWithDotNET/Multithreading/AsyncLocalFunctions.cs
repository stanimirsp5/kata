namespace KataCSharp.ProCSharpWithDotNET.Multithreading;

public class AsyncLocalFunctions
{
    public async Task Start()
    {
        await MyAsyncMethod(1, null);
        //await MyAsyncMethodFixed(1, null);
    }

    public static async Task MyAsyncMethod(int firstParameter, int? secondParameter)
    {
        Console.WriteLine("Enter");
        if (!secondParameter.HasValue)
        {
            Console.WriteLine("Missing second parameter");
            return;
        }
        await Task.Run(() =>
        {
            Thread.Sleep(1000); // Simulate some work
            Console.WriteLine("First complete");
            if (!secondParameter.HasValue)
            {
                Console.WriteLine("Something went bad");
            }
        });
        Console.WriteLine("Exit");
    }


    public static async Task MyAsyncMethodFixed(int firstParameter, int? secondParameter)
    {
        Console.WriteLine("Enter");
        if (!secondParameter.HasValue)
        {
            Console.WriteLine("Missing second parameter");
            return;
        }
        await innerAsyncMethod();

        async Task innerAsyncMethod()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000); // Simulate some work
                Console.WriteLine("First complete");
                if (!secondParameter.HasValue)
                    Console.WriteLine("Something went bad");
            });
        }
        Console.WriteLine("Exit");
    }
}