// Thread -> ThreadPool -> TPL -> syntax sugar + love = async await

Console.WriteLine($"Main method start in thread {Thread.CurrentThread.ManagedThreadId}"); // 1

//SomeMethod();
SomeMethodAsync();

Console.WriteLine($"Main method end in thread {Thread.CurrentThread.ManagedThreadId}"); // 1
Console.ReadKey();

void SomeMethod()
{
    Console.WriteLine($"SomeMethod start in thread {Thread.CurrentThread.ManagedThreadId}"); // 1
    var task = Task.Run(() =>
    {
        Console.WriteLine($"SomeMethod Task start in thread {Thread.CurrentThread.ManagedThreadId}"); // other thread
        Thread.Sleep(1000);
        Console.WriteLine($"SomeMethod Task end in thread {Thread.CurrentThread.ManagedThreadId}"); // other thread
        return 1;

    });
    Console.WriteLine(task.Result);
    Console.WriteLine($"SomeMethod end in thread {Thread.CurrentThread.ManagedThreadId}"); // 1
}

async void SomeMethodAsync()
{
    Console.WriteLine($"SomeMethodAsync start in thread {Thread.CurrentThread.ManagedThreadId}"); // 1
    var result = await Task.Run(() =>
    {
        Console.WriteLine($"SomeMethodAsync Task start in thread {Thread.CurrentThread.ManagedThreadId}"); // other thread
        Thread.Sleep(1000);
        Console.WriteLine($"SomeMethodAsync Task end in thread {Thread.CurrentThread.ManagedThreadId}"); // other thread
        return 1;
    });
    Console.WriteLine(result);
    Console.WriteLine($"SomeMethodAsync end in thread {Thread.CurrentThread.ManagedThreadId}"); // other thread
}