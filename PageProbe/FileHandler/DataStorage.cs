using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PageProbe.FileHandler
{
    class DataStorage
    {
        private readonly string _filePath = "changes.json";
        private List<DataSnapshot> _snapshots;

        public DataStorage()
        {
            _snapshots = LoadSnapshots();
        }

        private List<DataSnapshot> LoadSnapshots()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<DataSnapshot>>(json) ?? new List<DataSnapshot>();
            }
            return new List<DataSnapshot>();
        }

        public void SaveSnapshot(string url, string newHtml)
        {
            var snapshot = new DataSnapshot
            {
                Url = url,
                Timestamp = DateTime.UtcNow,
                Content = newHtml
            };

            _snapshots.Add(snapshot);
            string json = JsonSerializer.Serialize(_snapshots, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }

}