using System;
namespace TodoApi.Models
{
    public class LoginItem
    {
        public long Id { get; set; }
        public int device_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        
    }
}

