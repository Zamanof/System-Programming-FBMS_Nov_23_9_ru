// ThreadPool
//ThreadPool.GetAvailableThreads(out int workerCount, out int complCount);
//Console.WriteLine(workerCount);
//Console.WriteLine(complCount);

Console.WriteLine("Main method start...");

ThreadPool.QueueUserWorkItem(AsyncOperations!, "Hello");
ThreadPool.QueueUserWorkItem(_ =>
{
    SomeOperations();
});
// (x)=> {} -> void methodName(dataType x){}

Console.WriteLine($"Main method thread id: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Main method isBackground: {Thread.CurrentThread.IsBackground}");
Console.WriteLine($"Main method isThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");

Console.ReadLine();
Console.WriteLine("Main method end...");


void AsyncOperations(object state)
{
    Console.WriteLine("\tAsyncOperations method start...");
    Console.WriteLine($"\t{state.ToString()}");
    Thread.Sleep(10);
    Console.WriteLine($"\tAsyncOperations method thread id: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine($"\tAsyncOperations method isBackground: {Thread.CurrentThread.IsBackground}");
    Console.WriteLine($"\tAsyncOperations method isThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");
    Console.WriteLine("\tAsyncOperations method end...");
}

void SomeOperations()
{
    Console.WriteLine("\t\tSomeOperations method start...");

    Thread.Sleep(10);
    Console.WriteLine($"\t\tSomeOperations method thread id: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine($"\t\tSomeOperations method isBackground: {Thread.CurrentThread.IsBackground}");
    Console.WriteLine($"\t\tSomeOperations method isThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");
    Console.WriteLine("\t\tSomeOperations method end...");
}
