using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PageProbe.FileHandler;

class BaseCrawler
{
    private readonly HttpClient _client;

    public BaseCrawler()
    {
        _client = new HttpClient();
    }

    public async Task<string> FetchHtmlAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil ved henting av nettside: {ex.Message}");
            return string.Empty;
        }
    }

    public string ExtractTitle(string html)
    {
        int start = html.IndexOf("<title>") + 7;
        int end = html.IndexOf("</title>");
        return (start > 6 && end > start) ? html[start..end] : "(Ingen tittel funnet)";
    }

    public string ExtractMetaDescription(string html)
    {
        string tag = "<meta name=\"description\" content=\"";
        int start = html.IndexOf(tag);
        if (start == -1) return "(Ingen meta description funnet)";
        start += tag.Length;
        int end = html.IndexOf("\"", start);
        return (end > start) ? html[start..end] : "(Ingen meta description funnet)";
    }

    public string ExtractFirstHeading(string html)
    {
        int start = html.IndexOf("<h1>") + 4;
        int end = html.IndexOf("</h1>");
        return (start > 3 && end > start) ? html[start..end] : "(Ingen h1 funnet)";
    }

    public List<string> ExtractAllHeadings(string html, string tag)
    {
        List<string> headings = new();
        int start = 0;
        string openTag = $"<{tag}>";
        string closeTag = $"</{tag}>";
        
        while ((start = html.IndexOf(openTag, start)) != -1)
        {
            start += openTag.Length;
            int end = html.IndexOf(closeTag, start);
            if (end == -1) break;
            headings.Add(html[start..end]);
        }
        
        return headings;
    }

    public List<string> ExtractAllLinks(string html)
    {
        List<string> links = new();
        int start = 0;
        string tag = "href=\"";

        while ((start = html.IndexOf(tag, start)) != -1)
        {
            start += tag.Length;
            int end = html.IndexOf("\"", start);
            if (end == -1) break;

            string link = html[start..end];
            if (!link.StartsWith("#") && 
                !link.StartsWith("mailto:") && 
                !link.StartsWith("tel:") && 
                !link.StartsWith("javascript:"))
            {
                links.Add(link);
            }
        }
        
        return links;
    }
    public async Task MonitorWebsiteAsync(string url, int intervalSeconds, DataStorage storage)
    {
        string lastHtml = await FetchHtmlAsync(url);
        storage.SaveSnapshot(url, lastHtml);

        while (true)
        {
            await Task.Delay(intervalSeconds * 1000);
            string newHtml = await FetchHtmlAsync(url);

            if (newHtml != lastHtml)
            {
                Console.WriteLine("Endringer oppdaget på nettsiden!");
                Console.WriteLine("Forskjeller:");
                ShowDiff(lastHtml, newHtml);
                storage.SaveSnapshot(url, newHtml);
                lastHtml = newHtml;
            }
            else
            {
                Console.WriteLine("Ingen endringer oppdaget.");
            }
        }
    }

    private void ShowDiff(string oldHtml, string newHtml)
    {
        var oldLines = oldHtml.Split('\n');
        var newLines = newHtml.Split('\n');

        Console.WriteLine("=== Differences Detected ===");

        for (int i = 0; i < Math.Max(oldLines.Length, newLines.Length); i++)
        {
            string oldLine = i < oldLines.Length ? oldLines[i] : "";
            string newLine = i < newLines.Length ? newLines[i] : "";

            if (oldLine != newLine)
            {
                if (string.IsNullOrWhiteSpace(oldLine))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"+ {newLine}");
                }
                else if (string.IsNullOrWhiteSpace(newLine))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"- {oldLine}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"- {oldLine}");
                    Console.WriteLine($"+ {newLine}");
                }
            }
        }

        Console.ResetColor();
        Console.WriteLine("============================");
    }
}
