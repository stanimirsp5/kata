namespace KataCSharp.ProCSharpWithDotNET.Multithreading;

public class FunWithThreadPool
{
    public void Start()
    {
        Console.WriteLine("Main thread started. Thread id: {0}", Thread.CurrentThread.ManagedThreadId);
        var workItem = new WaitCallback(PrintNumbers);
        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(workItem, i);
        }
        Console.WriteLine("Main thread finished. Thread id: {0}", Thread.CurrentThread.ManagedThreadId);

        object t = "Hello";

        var myDelegate = new MyDelegate(MyMethod);
        myDelegate.Invoke();
        var myDelegate2 = () => MyMethod();
        myDelegate2.Invoke();

        Action myAction = MyMethod;
        myAction.Invoke();
    }

    public static void PrintNumbers2(object? data)
    {
        if (data is int index)
        {
            Console.WriteLine("Thread {0} is processing index {1}", Thread.CurrentThread.ManagedThreadId, index);
        }
    }

    public void PrintNumbers(object? data)
    {
        if (data is int index)
        {
            Console.WriteLine("Thread {0} is processing index {1}", Thread.CurrentThread.ManagedThreadId, index);
        }
    }

    public void MyMethod()
    {
        Console.WriteLine("MyMethod is running on thread {0}", Thread.CurrentThread.ManagedThreadId);
    }
    public void MyMethod(object state)
    {
        Console.WriteLine("MyMethod is running on thread {0}", Thread.CurrentThread.ManagedThreadId);
    }
    public delegate void MyDelegate();
    public delegate void MyDelegate2(object state);

}