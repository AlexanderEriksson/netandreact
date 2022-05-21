namespace Domain

{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string By {get; set; }
        public DateTime Date { get; set; }
    }
}