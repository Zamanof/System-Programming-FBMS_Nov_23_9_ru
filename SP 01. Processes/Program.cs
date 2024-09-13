using System.Diagnostics;

//Process.Start("cmd");
//Process.Start("mspaint");
//Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");

//Process.Start("calc");
//Console.WriteLine(Process.GetCurrentProcess().ProcessName);
//Console.WriteLine(Process.GetCurrentProcess().Id);

//var process = Process.GetProcessById(20760); // Process Id dinamicheski vidayetsya OS i kajdiy raz budet razlichatsya
//process.Kill();

var processes = Process.GetProcessesByName("CalculatorApp");

//foreach (var process in processes)
//{
//    Console.WriteLine($"{process.Id} - {process.ProcessName} - {process.Threads.Count}");
//    process.Kill();
//}

//var allProcess = Process.GetProcesses();

//foreach (var process in allProcess)
//{
//    Console.WriteLine($"{process.Id} - {process.ProcessName} - {process.Threads.Count}");
//}

//var current = Process.GetCurrentProcess();
//current.PriorityClass = ProcessPriorityClass.Normal;


ProcessStartInfo startInfo = new ProcessStartInfo("calc");
Process.Start(startInfo);

Console.ReadLine();