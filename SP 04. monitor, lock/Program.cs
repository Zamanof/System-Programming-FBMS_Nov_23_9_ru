#region Albahari tricks
// captured variable

//for (int i = 0; i < 10; i++)
//{
//    new Thread(() =>
//    {
//        Console.WriteLine(i);
//    }).Start();
//}

//for (int i = 0; i < 10; i++)
//{
//    int tmp = i;
//    new Thread(() =>
//    {
//        Console.WriteLine(tmp);
//    }).Start();
//}

//string name = "Nadir";
//Thread thread1 = new Thread(() =>
//{
//    Console.WriteLine(name);
//});
//name = "Zaman";
//Thread thread2 = new Thread(() =>
//{
//    Console.WriteLine(name);
//});
//thread1.Start();
//thread2.Start();
#endregion

// Critical section - koqda potoki obrashayutsya k obshey pamyati, resursam

#region Critical section problem
//Thread[] threads = new Thread[5];
//for (int i = 0; i< threads.Length; i++)
//{
//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {
//            Counter.Count++; // Counter.Count = Counter.Count + 1;
//        }
//    });
//}

//for (int i = 0;i< threads.Length; i++)
//{
//    threads[i].Start();
//}


//Console.WriteLine(Counter.Count);

//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i].Join();
//}

//Console.WriteLine(Counter.Count);


#endregion

#region Interlocked
//Thread[] threads = new Thread[5];
//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {

//            Interlocked.Increment(ref Counter.Count);
//            if (Counter.Count % 2 == 0)
//            {
//                Interlocked.Increment(ref Counter.Even);
//            }
//        }
//    });
//}

//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i].Start();
//}



//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i].Join();
//}

//Console.WriteLine(Counter.Count);
//Console.WriteLine(Counter.Even);
#endregion


#region Monitor
//Thread[] threads = new Thread[5];
//object obj = new object();
//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {
//            Monitor.Enter(obj);
//            try
//            {
//                Counter.Count++;
//                if (Counter.Count % 2 == 0)
//                {
//                    Counter.Even++;
//                }
//            }
//            finally
//            {

//                Monitor.Exit(obj);
//            }

//        }
//    });
//}

//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i].Start();
//}



//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i].Join();
//}

//Console.WriteLine(Counter.Count);
//Console.WriteLine(Counter.Even);
#endregion

#region lock
Thread[] threads = new Thread[5];
object obj = new object();
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(() =>
    {
        for (int j = 0; j < 1000000; j++)
        {
            lock (obj)
            {
                Counter.Count++;
                if (Counter.Count % 2 == 0)
                {
                    Counter.Even++;
                }
            }

        }
    });
}

for (int i = 0; i < threads.Length; i++)
{
    threads[i].Start();
}



for (int i = 0; i < threads.Length; i++)
{
    threads[i].Join();
}

Console.WriteLine(Counter.Count);
Console.WriteLine(Counter.Even);
#endregion

class Counter
{
    public static int Count = 0;
    public static int Even = 0;
}