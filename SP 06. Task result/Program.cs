Console.WriteLine("Start of code.");
var task = Task.Run(() => TaskReturnMethod("Task1", 5));

Console.WriteLine(task.Result);
Console.WriteLine("End of code.");

int TaskReturnMethod(string message, int second)
{
    Console.WriteLine("TaskReturnMethod start...");
    Console.WriteLine(@$"Task - {message} is running.
Id - {Thread.CurrentThread.ManagedThreadId}
IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}
IsBackgroundThread - {Thread.CurrentThread.IsBackground}");
    Console.WriteLine("TaskReturnMethod end...\n");
    Thread.Sleep(second * 1000);
    return second * 10;
}

