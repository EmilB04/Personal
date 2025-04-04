using System;
using System.Net.Http;
using System.Threading.Tasks;
using PageProbe.FileHandler;

namespace PageProbe;

class Program
{
    static async Task Main()
    {
        string url = "https://elkjop.no";
        Console.WriteLine($"Overvåker: {url}\n");

        BaseCrawler crawler = new BaseCrawler();
        DataStorage storage = new DataStorage();

        await crawler.MonitorWebsiteAsync(url, 30, storage); // Sjekker hver 30. sekund
    }
}