namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        //public string Name { get; set; }
        //public bool IsComplete { get; set; }

        public int participant_id { get; set; }
        public int device_id { get; set; }
        public string date { get; set; }
        public int heart_rate { get; set; }
    }
}