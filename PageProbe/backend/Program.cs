// Program.cs – startpunkt for CLI-basert crawling i PageProbe

using System;
using PageProbe.FileHandler;

namespace PageProbe
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Bruk: dotnet run -- <url>");
                return;
            }

            string url = args[0];
            var crawler = new BaseCrawler();
            var storage = new DataStorage();

            try
            {
                Console.WriteLine($"Starter crawling av: {url}");
                string html = crawler.FetchHtmlAsync(url).Result;
                storage.SaveSnapshot(url, html);
                Console.WriteLine("Snapshot lagret!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Feil under crawling: {ex.Message}");
            }
        }
    }
}
