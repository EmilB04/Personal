using System;
using System.Net.Http;
using System.Threading.Tasks;
using PageProbe.FileHandler;

namespace PageProbe;

class Program
{
    static async Task Main()
    {
        string url = "https://nrk.no";
        Console.WriteLine($"Henter data fra: {url}\n");

        BaseCrawler crawler = new BaseCrawler();
        DataStorage storage = new DataStorage();
        string html = await crawler.FetchHtmlAsync(url);

        if (!string.IsNullOrEmpty(html))
        {
            Console.WriteLine($"Tittel: {crawler.ExtractTitle(html)}");
            Console.WriteLine($"Meta Description: {crawler.ExtractMetaDescription(html)}");
            Console.WriteLine($"Første H1: {crawler.ExtractFirstHeading(html)}\n");
            
            Console.WriteLine("Alle H2:");
            foreach (var h2 in crawler.ExtractAllHeadings(html, "h2"))
                Console.WriteLine("- " + h2);
            
            Console.WriteLine("\nAlle lenker:");
            foreach (var link in crawler.ExtractAllLinks(html))
                Console.WriteLine("- " + link);
        }

        Console.WriteLine($"Overvåker: {url}\n");
        await crawler.MonitorWebsiteAsync(url, 30, storage); // Sjekker hver 30. sekund
    }
}