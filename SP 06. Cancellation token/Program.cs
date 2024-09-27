#region Thread Interrupt method
//Thread thread = new Thread(Download);
//thread.Start();

//var key = Console.ReadKey();
//if (key.Key == ConsoleKey.Enter)
//{
//    Console.WriteLine("Downloading process cancel...");
//    thread.Interrupt();
//}

//void Download(object? obj)
//{
//    Console.WriteLine("Downloading start...");
//    Thread.Sleep(1000);
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine($"{i} %");
//        Thread.Sleep(500);
//        Console.Clear();
//    }
//    Console.WriteLine("Downloading end...");
//}
#endregion


#region Cancellation Token with return (Soft cancel)
//using CancellationTokenSource cts = new CancellationTokenSource();
//CancellationToken token = cts.Token;

//ThreadPool.QueueUserWorkItem(o =>
//{
//    Download(token);
//});

//while (true)
//{
//    var key = Console.ReadKey();
//    if (key.Key == ConsoleKey.Enter)
//    {
//        cts.Cancel();
//        Thread.Sleep(1000);
//        Console.WriteLine("Downloading process cancel...");
//        Thread.Sleep(1000);
//        Console.ReadKey();
//        break;
//    }
//}

//void Download(CancellationToken token)
//{
//    Console.WriteLine("Downloading start...");
//    Thread.Sleep(1000);
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine($"{i} %");
//        Thread.Sleep(500);
//        Console.Clear();
//        if (token.IsCancellationRequested)
//        {
//            return;
//        }
//    }
//    Console.WriteLine("Downloading end...");
//}
#endregion

#region Cancellation Token with exception (Hard cancel)
//using CancellationTokenSource cts = new CancellationTokenSource();

//CancellationToken token = cts.Token;

//ThreadPool.QueueUserWorkItem(o =>
//{
//    try 
//    { 
//        Download(token); 
//    } 
//    catch(OperationCanceledException ex)
//    {
//        Console.WriteLine(ex.Message);
//        Console.WriteLine("Downloading process cancel...");
//    }

//});

//while (true)
//{
//    var key = Console.ReadKey();
//    if (key.Key == ConsoleKey.Enter)
//    {
//        cts.Cancel();
//        Thread.Sleep(1000);
//        Console.ReadKey();
//        break;
//    }
//}

//void Download(CancellationToken token)
//{
//    Console.WriteLine("Downloading start...");
//    Thread.Sleep(1000);
//    for (int i = 0; i < 100; i++)
//    {
//        token.ThrowIfCancellationRequested();
//        Console.WriteLine($"{i} %");
//        Thread.Sleep(500);
//        Console.Clear();
//    }
//    Console.WriteLine("Downloading end...");
//}

#endregion