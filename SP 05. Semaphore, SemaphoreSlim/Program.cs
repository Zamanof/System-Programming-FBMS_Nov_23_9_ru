﻿// Monitor/lock & Mutex - lock mechanism
// Semaphore & SemaphoreSlim - signaling mechanism


#region Semaphore internal threads

//Semaphore semaphore = new Semaphore(3, 3);
//for (int i = 0; i < 15; i++)
//{
//    ThreadPool.QueueUserWorkItem(Some, semaphore);
//}

//Console.ReadKey();
//void Some(object? state)
//{
//    var s = state as Semaphore;
//    bool st = false;
//    while (!st)
//    {
//        if (s.WaitOne(500))
//        {
//            try
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} take key.");
//                Thread.Sleep(3000);
//            }
//            finally
//            {
//                Console.ForegroundColor = ConsoleColor.Green;
//                st = true;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} return key.");
//                s.Release();
//            }
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} sorry no keys yet.");

//        }
//    }
//}

#endregion


#region Semaphore internal threads

//Semaphore semaphore = new Semaphore(3, 3, "Tamerlan");

//for (int i = 0; i < 15; i++)
//{
//    ThreadPool.QueueUserWorkItem(Some, semaphore);
//}

//Console.ReadKey();
//void Some(object? state)
//{
//    var s = state as Semaphore;
//    bool st = false;
//    while (!st)
//    {
//        if (s.WaitOne(500))
//        {
//            try
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} take key.");
//                Thread.Sleep(10000);
//            }
//            finally
//            {
//                Console.ForegroundColor = ConsoleColor.Green;
//                st = true;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} return key.");
//                s.Release();
//            }
//        }
//        else
//        {
//            //Thread.Sleep(500);
//            //Console.ForegroundColor = ConsoleColor.White;
//            //Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} sorry no keys yet.");

//        }
//    }
//}

#endregion


#region SemaphoreSlim internal threads

//SemaphoreSlim semaphore = new SemaphoreSlim(3, 3);
//for (int i = 0; i < 15; i++)
//{
//    ThreadPool.QueueUserWorkItem(Some, semaphore);
//}

//Console.ReadKey();
//void Some(object? state)
//{
//    var s = state as SemaphoreSlim;
//    bool st = false;
//    while (!st)
//    {
//        if (s.Wait(500))
//        {
//            try
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} take key.");
//                Thread.Sleep(3000);
//            }
//            finally
//            {
//                Console.ForegroundColor = ConsoleColor.Green;
//                st = true;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} return key.");
//                s.Release();
//            }
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} sorry no keys yet.");

//        }
//    }
//}

#endregion


