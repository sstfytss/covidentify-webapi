using System;
namespace TodoApi.Models
{
    public class AppleWatchItem
    {
        public long Id { get; set; }
        public int device_id { get; set; }
        public int access_token { get; set; }
        public int refresh_token { get; set; }
        public string registered_date { get; set; }
    }
}

