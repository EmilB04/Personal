using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PageProbe.FileHandler
{
    class DataStorage
    {
        private readonly string _directory = "snapshots";

        public DataStorage()
        {
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
        }

        public void SaveSnapshot(string url, string newHtml)
        {
            string currentDate = DateTime.Now.ToString("dd_MMMM_yyyy"); // Folder name with the date spelled out in letters
            string dailyDirectory = Path.Combine(_directory, currentDate);

            // Ensure the daily directory exists
            if (!Directory.Exists(dailyDirectory))
            {
                Directory.CreateDirectory(dailyDirectory);
            }

            string safeUrl = url.Replace("https://", "").Replace("http://", "").Replace("/", "_");
            string timestamp = DateTime.Now.ToString("HH:mm.ss"); // File name based on the current time
            string fileName = Path.Combine(dailyDirectory, $"{safeUrl}_{timestamp}.json");

            // Optionally format the HTML content
            string formattedHtml = FormatHtml(newHtml);

            var snapshot = new DataSnapshot
            {
                Url = url,
                Timestamp = DateTime.UtcNow,
                Content = formattedHtml
            };

            string json = JsonSerializer.Serialize(snapshot, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, json);
        }

        private string FormatHtml(string html)
        {
            // A simple example of formatting HTML (you can replace this with a proper HTML formatter)
            return html.Replace(">", ">\n").Replace("<", "\n<").Trim();
        }
    }
}