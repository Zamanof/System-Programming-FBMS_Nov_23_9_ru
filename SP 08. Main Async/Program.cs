using System.Net;

namespace SP_08._Main_Async
{
    internal class Program
    {
        static WebClient client = new();
        //static void Main(string[] args)
        //{
        //    string url = @"https://www.google.com/search?sca_esv=029398843723f323&sca_upv=1&sxsrf=ADLYWIIBaFLruLbyihRkD5VlNapSovAdGA:1727678663822&q=frontend+vs+backend+meme&udm=2&fbs=AEQNm0B4j3QKI-NeS3I9QI4lfRITA3BMgTEoh7pxQl7OKOagFhQ5f-GTPpZVEZdeBF_-JXL4PW9TA5psBqLHDJ5Ovug5882aVWx6Twh3mEBB-KwduwSPO7MQQMu4UHtlqay6IHw2MgG6PgeZ4u_oKsGApgxraN2OsEe-24evB9GKIduYYoCmX9sFf6BiuTHA46Jg4uR64xpgkBYhUBUBW6-S0HQbJj4bxagAJgxDgeLB3C7LTsosONk&sa=X&ved=2ahUKEwi186vIiOqIAxVCcvEDHaR1DqAQtKgLegQIDhAB&biw=1310&bih=958&dpr=1";
        //    //DownloadAndShowTextAsync(url);
        //    //DownloadAndShowText(url);
        //    //for (int i = 0; i < 100; i++)
        //    //{
        //    //    Thread.Sleep(100);
        //    //    Console.WriteLine($"{i} - run");
        //    //}
        //    //var text = DownloadText(url);
        //    //Console.WriteLine(text);
        //    //Console.WriteLine(DownloadTextAsync(url).Result);
        //    //var task = client.DownloadStringTaskAsync(url);
        //    //Console.WriteLine(task.Result);

        //}
        static async Task Main(string[] args)
        {
            string url = @"https://www.google.com/search?sca_esv=029398843723f323&sca_upv=1&sxsrf=ADLYWIIBaFLruLbyihRkD5VlNapSovAdGA:1727678663822&q=frontend+vs+backend+meme&udm=2&fbs=AEQNm0B4j3QKI-NeS3I9QI4lfRITA3BMgTEoh7pxQl7OKOagFhQ5f-GTPpZVEZdeBF_-JXL4PW9TA5psBqLHDJ5Ovug5882aVWx6Twh3mEBB-KwduwSPO7MQQMu4UHtlqay6IHw2MgG6PgeZ4u_oKsGApgxraN2OsEe-24evB9GKIduYYoCmX9sFf6BiuTHA46Jg4uR64xpgkBYhUBUBW6-S0HQbJj4bxagAJgxDgeLB3C7LTsosONk&sa=X&ved=2ahUKEwi186vIiOqIAxVCcvEDHaR1DqAQtKgLegQIDhAB&biw=1310&bih=958&dpr=1";
            Console.WriteLine(await client.DownloadStringTaskAsync(url));
        }
        static string DownloadText(string url)
        {
            return client.DownloadString(url);
        }
        static void DownloadAndShowText(string url)
        {
            //Thread.Sleep(1000);
            Console.WriteLine(client.DownloadString(url));
        }


        static async Task<string> DownloadTextAsync(string url)
        {
            return await client.DownloadStringTaskAsync(url);
        }

        static async void DownloadAndShowTextAsync(string url)
        {
            //Thread.Sleep(1000);
            Console.WriteLine(await client.DownloadStringTaskAsync(url));
        }

    }
}