// TPL - Task Parallel Library

// Thread -> ThreadPool -> TPL

Console.WriteLine("Start of code...");

//Task task1 = new Task(() =>
//{
//    TaskMethod("Task 1");
//});

//Task task2 = new Task(() =>
//{
//    TaskMethod("Task 2");
//});

//Task task3 = Task.Run(() =>
//{
//    TaskMethod("Task 3");
//});

//Task task4 = Task.Factory.StartNew(() =>
//{
//    TaskMethod("Task 4");
//});

var task5 = new Task(() => {
    TaskMethod("Task 5");
}, TaskCreationOptions.LongRunning);

//task1.Start();
//task2.Start();
task5.Start();


//task1.Wait();
//task2.Wait();
Console.ReadKey();
Console.WriteLine("End of code...");


void TaskMethod(string message)
{
    Console.WriteLine("Task Method start...");
    Console.WriteLine(@$"Task - {message} is running.
Id - {Thread.CurrentThread.ManagedThreadId}
IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}
IsBackgroundThread - {Thread.CurrentThread.IsBackground}");
    Console.WriteLine("Task Method end...\n");
}