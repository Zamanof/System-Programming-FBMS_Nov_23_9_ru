using System.Diagnostics;

// CLR ThreadPool threads:
// 1. class ThreadPool
// 2. Windows Forms Timer
// 3. Asynchronous methods (delegate methods BeginInvoke, EndInvoke -> deprecated methods)
// 4. TPL (Task Parallel Library)




int operationCount = 500;
var watch = new Stopwatch();
watch.Start();
UseThread(operationCount);
watch.Stop();
Console.WriteLine($"Milliseconds {watch.ElapsedMilliseconds}");
watch.Reset();

watch.Start();
UseThreadPool(operationCount);
watch.Stop();
Console.WriteLine($"Milliseconds {watch.ElapsedMilliseconds}");



Console.ReadLine();
void UseThread(int operationCount)
{
    Console.WriteLine("Thread...");

    using (var count = new CountdownEvent(operationCount))
    {
        for (int i = 0; i < operationCount; i++)
        {
            var thread = new Thread(() =>
            {
                Thread.Sleep(10);
                //Console.WriteLine($"Thread thread id: {Thread.CurrentThread.ManagedThreadId}");
                count.Signal();
            });
            thread.Start();
        }
        count.Wait();
    }
}

void UseThreadPool(int operationCount)
{
    Console.WriteLine("ThreadPool...");
    //List<int> threads = [];
    using (var count = new CountdownEvent(operationCount))
    {
        for (int i = 0; i < operationCount; i++)
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                Thread.Sleep(10);
                //Console.WriteLine($"ThreadPool thread id: {Thread.CurrentThread.ManagedThreadId}");
                //if( !threads.Contains(Thread.CurrentThread.ManagedThreadId))
                //{
                //    threads.Add(Thread.CurrentThread.ManagedThreadId);
                //}
                count.Signal();
            });
        }
        count.Wait();
    }
    //Console.WriteLine($"Count of threads {threads.Count}");
}
