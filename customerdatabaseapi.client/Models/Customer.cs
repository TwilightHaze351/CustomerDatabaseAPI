namespace CustomerDatabaseAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public string Email { get; set; }
        public ICollection<CallAttempt> CallAttempts { get; set; } = new List<CallAttempt>();
    }
}
