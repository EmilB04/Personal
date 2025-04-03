using System;

namespace PageProbe.FileHandler
{
    class DataSnapshot
    {
        public required string Url { get; set; }
        public DateTime Timestamp { get; set; }
        public required string Content { get; set; }
    }
}