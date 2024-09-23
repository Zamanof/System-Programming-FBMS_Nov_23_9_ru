// Monitor/lock & Mutex - lock mechanism
// Semaphore & SemaphoreSlim - signaling mechanism


#region Mutex (Mutual exclusion) internal threads
//Mutex mutex = new Mutex();
//int numb = 1;
//for (int i = 0; i < 5; i++)
//{
//    Thread thread = new(Count);
//    thread.Name = $"mr. Thread number {i}";
//    thread.Start();
//}
//void Count()
//{
//    mutex.WaitOne();
//    for (int i = 0; i< 10; i++)
//    {
//        Console.WriteLine($"{Thread.CurrentThread.Name}: {numb++}");
//    }
//    mutex.ReleaseMutex();
//}
#endregion

#region Global Mutex external threads
//string mutexName = "Napoleon";
//using var mutex = new Mutex(false, mutexName);
//if (!mutex.WaitOne(30000))
//{
//    Console.WriteLine("Other instance is running...");
//    Thread.Sleep(1000);
//    return;
//}
//else
//{
//    Console.WriteLine("My Code is running");
//    Console.ReadKey();
//    mutex.ReleaseMutex();
//}
#endregion